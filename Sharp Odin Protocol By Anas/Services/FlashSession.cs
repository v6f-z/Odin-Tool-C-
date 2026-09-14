using System;
using System.Drawing;
using System.Threading.Tasks;
using Sharp_Odin_Protocol_By_Anas.Flash;

namespace Sharp_Odin_Protocol_By_Anas.Services
{
    public sealed class FlashSession
    {
        private readonly FlashManager _flashManager;
        private readonly PitManager _pitManager;

        public event Action<string, Color, bool> OnLog;
        public event Action<string, long, long, long> OnProgressChanged;
        public event Action<bool> OnRunningChanged;

        public FlashSession(FlashManager flashManager, PitManager pitManager)
        {
            _flashManager = flashManager;
            _pitManager = pitManager;

            _flashManager.OnLog += (text, color, newLine) => OnLog?.Invoke(text, color, newLine);
            _flashManager.OnProgressChanged += (fileName, max, value, writtenSize) =>
                OnProgressChanged?.Invoke(fileName, max, value, writtenSize);
            _flashManager.OnRunningChanged += isRunning => OnRunningChanged?.Invoke(isRunning);

            _pitManager.OnLog += (text, isError) =>
                OnLog?.Invoke(text + "\n", isError ? Color.Red : Color.LimeGreen, true);
            _pitManager.OnRunningChanged += isRunning => OnRunningChanged?.Invoke(isRunning);
        }

        public async Task StartFlashAsync(FlashOptions options)
        {
            await _flashManager.StartFlash(
                options.BlPath,
                options.ApPath,
                options.CpPath,
                options.CscPath,
                options.PitPath,
                options.Repartition,
                options.UpdateBoot,
                options.ClearEfs,
                options.AutoReboot,
                options.Files);
        }

        public async Task<string> ReadPitAsync(string saveFolder, bool autoReboot)
        {
            return await _pitManager.ReadPitFromDevice(saveFolder, autoReboot);
        }
    }
}
