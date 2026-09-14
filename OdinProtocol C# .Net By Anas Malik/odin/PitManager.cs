using System;
using System.IO;
using System.Threading.Tasks;
using SharpOdinClient;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Flash
{
    public class PitManager
    {
        private readonly Odin _odin;

        public event Action<string, bool> OnLog;
        public event Action<bool> OnRunningChanged;

        public PitManager()
        {
            _odin = new Odin();
        }

        public async Task<string> ReadPitFromDevice(string saveFolderPath, bool autoReboot = true)
        {
            try
            {
                OnRunningChanged?.Invoke(true);
                Log("Searching for device in Download Mode...", false);

                if (!await _odin.FindAndSetDownloadMode())
                {
                    Log("Device not found! Make sure it's in Download Mode.", true);
                    return "";
                }

                await _odin.PrintInfo();

                Log("Checking Download Mode : ", false);
                if (!await _odin.IsOdin())
                {
                    Log("Failed - Not in ODIN mode", true);
                    return "";
                }
                Log("ODIN OK", false);

                Log("Initializing Device : ", false);
                if (!await _odin.LOKE_Initialize(0))
                {
                    Log("Failed to initialize device", true);
                    return "";
                }
                Log("Initialized OK", false);

                Log("Reading PIT from device : ", false);
                var pitResult = await _odin.Read_Pit();

                if (!pitResult.Result)
                {
                    Log("Failed to read PIT", true);
                    return "";
                }
                Log("OK", false);

                string fileName = "PIT_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".pit";
                string fullPath = Path.Combine(saveFolderPath, fileName);

                try
                {
                    if (!Directory.Exists(saveFolderPath))
                    {
                        Directory.CreateDirectory(saveFolderPath);
                    }
                }
                catch { }

                File.WriteAllBytes(fullPath, pitResult.data);
                Log("PIT saved to: " + fullPath, false);

                if (autoReboot)
                {
                    Log("Rebooting Device To Normal Mode : ", false);
                    if (await _odin.PDAToNormal())
                    {
                        Log("OK", false);
                    }
                    else
                    {
                        Log("Reboot failed - try manual reboot", true);
                    }
                }
                else
                {
                    Log("Auto Reboot Disabled - Reboot manually", false);
                }

                return fullPath;
            }
            catch (Exception ex)
            {
                Log("System Error: " + ex.Message, true);
                return "";
            }
            finally
            {
                OnRunningChanged?.Invoke(false);
            }
        }

        private void Log(string text, bool isError)
        {
            OnLog?.Invoke(text, isError);
        }
    }
}