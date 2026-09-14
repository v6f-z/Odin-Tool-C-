using SharpOdinClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Flash
{
    public class FlashManager
    {
        private readonly Odin _odin;
        private bool _isRunning;

        #region Events

        public event Action<string, Color, bool> OnLog;
        public event Action<string, long, long, long> OnProgressChanged;
        public event Action<bool> OnRunningChanged;
        public event Action OnStopped;

        #endregion

        #region Properties

        public bool IsRunning
        {
            get { return _isRunning; }
            private set
            {
                _isRunning = value;
                OnRunningChanged?.Invoke(value);
            }
        }

        #endregion

        public FlashManager()
        {
            _odin = new Odin();
            _odin.Log += HandleOdinLog;
            _odin.ProgressChanged += (filename, max, value, writtenSize) =>
            {
                OnProgressChanged?.Invoke(filename, max, value, writtenSize);
            };
        }

        #region Public Methods

        public void StopFlash()
        {
            try
            {
                if (IsRunning)
                {
                    _odin.StopOperations();
                    Log("Flash operation stopped by user", Color.Red, true);
                    OnStopped?.Invoke();
                }
            }
            catch (Exception ex)
            {
                Log("Stop error: " + ex.Message, Color.Red, true);
            }
        }

        public async Task StartFlash(
            string blPath,
            string apPath,
            string cpPath,
            string cscPath,
            string pitPath,
            bool repartition,
            bool updateBoot,
            bool clearEfs,
            bool autoReboot,
            List<FlashFileItem> enabledFiles)
        {
            try
            {
                IsRunning = true;

                var selectedFiles = enabledFiles
                    .Where(x => x != null)
                    .ToList();

                var flashList = new List<SharpOdinClient.structs.FileFlash>();

                foreach (var item in selectedFiles)
                {
                    flashList.Add(new SharpOdinClient.structs.FileFlash
                    {
                        Enable = true,
                        FileName = item.FileName,
                        FilePath = item.FilePath,
                        RawSize = item.RawSize
                    });
                }

                long totalSize = selectedFiles.Sum(x => x.RawSize);

                if (flashList.Count == 0 &&
                    (!string.IsNullOrEmpty(pitPath) && repartition))
                {
                    totalSize = 0;
                }
                else if (flashList.Count == 0)
                {
                    Log("Please select firmware files and try again.", Color.Yellow, true);
                    return;
                }

                Log("Total firmware size: ", Color.White, false);
                Log(FlashFileItem.GetBytesReadable(totalSize), Color.Cyan, true);

                Log("Searching for device in Download Mode...", Color.White, true);

                if (!await _odin.FindAndSetDownloadMode())
                {
                    Log("Device not found! Make sure it's in Download Mode.", Color.Red, true);
                    return;
                }

                await _odin.PrintInfo();

                Log("Checking Download Mode : ", Color.White, false);

                if (!await _odin.IsOdin())
                {
                    Log("FAILED", Color.Red, true);
                    return;
                }

                Log("OK", Color.Cyan, true);

                Log("Initializing Device : ", Color.White, false);

                if (!await _odin.LOKE_Initialize(totalSize))
                {
                    Log("FAILED", Color.Red, true);
                    return;
                }

                Log("OK", Color.Cyan, true);

                if (!string.IsNullOrEmpty(pitPath) && repartition)
                {
                    Log("Repartitioning Device : ", Color.White, false);

                    var repResult = await _odin.Write_Pit(pitPath);

                    if (repResult.status)
                    {
                        Log("OK", Color.Cyan, true);
                    }
                    else
                    {
                        Log("FAILED: " + repResult.error, Color.Red, true);
                        return;
                    }
                }

                Log("Reading PIT from device : ", Color.White, false);

                var pitResult = await _odin.Read_Pit();

                if (!pitResult.Result)
                {
                    Log("FAILED", Color.Red, true);
                    return;
                }

                Log("OK", Color.Cyan, true);

                int efsClear = clearEfs ? 1 : 0;
                int bootUpdate = updateBoot ? 1 : 0;

                Log("", Color.White, true);
                Log("Start Flashing Firmware...", Color.LimeGreen, true);
                Log("", Color.White, true);

                bool flashOk = await _odin.FlashFirmware(
                    flashList,
                    pitResult.Pit,
                    efsClear,
                    bootUpdate,
                    true);

                if (flashOk)
                {
                    if (autoReboot)
                    {
                        Log("", Color.White, true);
                        Log("Rebooting Device To Normal Mode : ", Color.White, false);

                        if (await _odin.PDAToNormal())
                        {
                            Log("OK", Color.Cyan, true);
                        }
                        else
                        {
                            Log("FAILED - Try manual reboot.", Color.Red, true);
                        }
                    }
                    else
                    {
                        Log("", Color.White, true);
                        Log("Auto Reboot Disabled - Remove cable and power on manually.", Color.Yellow, true);
                    }
                }
                else
                {
                    Log("", Color.White, true);
                    Log("Flash operation FAILED!", Color.Red, true);
                }
            }
            catch (Exception ex)
            {
                Log("System Error: " + ex.Message, Color.Red, true);
            }
            finally
            {
                IsRunning = false;
            }
        }

        private string _pendingOdinLog = string.Empty;
        private bool _pendingIsFlashingLog = false;

        private void HandleOdinLog(
            string text,
            SharpOdinClient.util.utils.MsgType msgType,
            bool isError)
        {
            if (msgType == SharpOdinClient.util.utils.MsgType.Message)
            {
                string title = text.Trim();

                // إزالة جميع النقطتين الزائدتين من النهاية
                while (title.EndsWith(":"))
                {
                    title = title
                        .Substring(0, title.Length - 1)
                        .TrimEnd();
                }

                _pendingOdinLog = title;
                _pendingIsFlashingLog = title.StartsWith(
                    "Flashing ",
                    StringComparison.OrdinalIgnoreCase);

                // لوج تفليش الملفات: نطبع اسم الملف فوراً عند بداية التفليش
                // والنتيجة (OK/Failed) تكتمل بنفس السطر لما توصل لاحقاً
                if (_pendingIsFlashingLog)
                {
                    Log(title + " : ", Color.White, false);
                }

                return;
            }

            if (msgType != SharpOdinClient.util.utils.MsgType.Result)
                return;

            string pendingTitle = _pendingOdinLog;
            bool wasFlashingLog = _pendingIsFlashingLog;
            _pendingOdinLog = string.Empty;
            _pendingIsFlashingLog = false;

            // إذا وصلت نتيجة بدون عنوان
            if (string.IsNullOrEmpty(pendingTitle))
            {
                Log(text, isError ? Color.Red : Color.White, true);
                return;
            }

            // لوج تفليش الملفات:
            // العنوان طبعناه مسبقاً عند البداية، هنا نكمل فقط بالنتيجة بنفس السطر
            if (wasFlashingLog)
            {
                Log(
                    isError ? "Failed" : "OK",
                    isError ? Color.Red : Color.LimeGreen,
                    true);

                return;
            }

            // معلومات الجهاز:
            // العنوان Cyan والقيمة أبيض
            Log(pendingTitle, Color.Cyan, false);
            Log(text.Trim(), Color.White, true);
        }

        public List<FlashFileItem> ReadTarFile(string tarPath, string packageType)
        {
            var reader = new TarPartitionReader();
            return reader.ReadTarContents(tarPath, packageType);
        }

        public bool ValidatePit(string pitPath, string pitFileName = null)
        {
            var reader = new TarPartitionReader();
            return reader.ValidatePitFile(pitPath, pitFileName);
        }

        public string FindPitInTar(string tarPath)
        {
            var reader = new TarPartitionReader();
            return reader.FindPitInTar(tarPath);
        }

        #endregion

        private void Log(string text, Color color, bool newLine = true)
        {
            OnLog?.Invoke(text, color, newLine);
        }
    }
}