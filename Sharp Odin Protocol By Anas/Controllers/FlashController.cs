using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Sharp_Odin_Protocol_By_Anas.Flash;
using Sharp_Odin_Protocol_By_Anas.Services;
using Sharp_Odin_Protocol_By_Anas.UI;

namespace Sharp_Odin_Protocol_By_Anas.Controllers
{
    public sealed class FlashController
    {
        private readonly FlashView _view;
        private readonly FlashSession _session;
        private readonly FirmwarePackageService _packages;
        private readonly FirmwareRepository _repository;
        private readonly PartitionGridView _grid;
        private readonly LogConsole _console;
        private readonly ProgressIndicator _progress;
        private readonly FlashControlsState _controls;

        public FlashController(FlashView view)
        {
            _view = view;

            var flashManager = new FlashManager();
            var pitManager = new PitManager();

            _session = new FlashSession(flashManager, pitManager);
            _packages = new FirmwarePackageService(flashManager);
            _repository = new FirmwareRepository();
            _grid = new PartitionGridView(view.PartGrid);
            _console = new LogConsole(view.LogBox);
            _progress = new ProgressIndicator(view.ProgressBar);
            _controls = new FlashControlsState(
                view.PitButton,
                view.OpenBl,
                view.OpenAp,
                view.OpenCp,
                view.OpenCsc,
                view.FlashButton,
                view.ReadPitButton,
                view.ClearButton,
                view.AutoReboot,
                view.Repartition,
                view.UpdateBoot,
                view.ClearEfs);

            WireEvents();
        }

        private void WireEvents()
        {
            _session.OnLog += (text, color, newLine) =>
                _console.Write(newLine ? text + Environment.NewLine : text, color);

            _session.OnProgressChanged += (fileName, max, value, writtenSize) =>
                UiDispatcher.RunOnUi(_view.ProgressBar, () => _progress.Update(fileName, max, value));

            _session.OnRunningChanged += isRunning =>
                UiDispatcher.RunOnUi(_view.ProgressBar, () => _controls.SetEnabled(!isRunning));
        }

        public void SelectPit()
        {
            string path = UserPrompts.SelectPitFile();

            if (path == null)
            {
                return;
            }

            PitSelectionResult result = _packages.SelectPit(path);

            if (!result.HasPit)
            {
                _console.Write(result.Message, Color.Yellow);
                return;
            }

            if (result.Valid)
            {
                _view.PitPath.Text = path;
                _view.Repartition.Checked = true;
                _console.Write(result.Message, Color.LimeGreen);
            }
            else
            {
                _view.PitPath.Clear();
                _view.Repartition.Checked = false;
                _console.Write(result.Message, Color.Red);
            }
        }

        public void OpenPackage(string packageType)
        {
            string path = UserPrompts.SelectFirmwarePackage(packageType);

            if (path == null)
            {
                return;
            }

            SetPackagePath(packageType, path);

            var files = _packages.OpenPackage(path, packageType);

            if (files.Count == 0)
            {
                _console.Write(string.Format("{0}: No files found or error reading package\n", packageType), Color.Yellow);
                return;
            }

            _repository.ReplacePackage(packageType, files);
            _grid.LoadFiles(_repository.All);
            _grid.CheckAll();

            _console.Write(string.Format("{0}: {1} partitions loaded\n", packageType, files.Count), Color.LimeGreen);
        }

        private void SetPackagePath(string packageType, string path)
        {
            if (packageType == "BL")
            {
                _view.BlPath.Text = path;
            }
            else if (packageType == "AP")
            {
                _view.ApPath.Text = path;
            }
            else if (packageType == "CP")
            {
                _view.CpPath.Text = path;
            }
            else if (packageType == "CSC")
            {
                _view.CscPath.Text = path;
            }
        }

        public async Task StartFlash()
        {
            try
            {
                _grid.CommitEdits();
                var files = _grid.GetCheckedFiles();
                FlashOptions options = _view.BuildOptions(files);

                if (files.Count == 0 && !options.Repartition)
                {
                    _console.Write("Please select firmware files first!\n", Color.Yellow);
                    return;
                }

                if (options.ClearEfs && !UserPrompts.ConfirmEfsClear())
                {
                    _view.ClearEfs.Checked = false;
                    return;
                }

                if (options.Repartition && string.IsNullOrWhiteSpace(options.PitPath))
                {
                    _console.Write("Repartition is checked but no PIT file selected!\n", Color.Yellow);
                    return;
                }

                await _session.StartFlashAsync(options);
            }
            catch (Exception ex)
            {
                _console.Write(string.Format("Flash error: {0}\n", ex.Message), Color.Red);
            }
        }

        public async Task ReadPit()
        {
            try
            {
                string saveFolder = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Backup", "Samsung", "Pit");

                await _session.ReadPitAsync(saveFolder, _view.AutoReboot.Checked);
            }
            catch (Exception ex)
            {
                _console.Write(string.Format("Read PIT error: {0}\n", ex.Message), Color.Red);
            }
        }

        public void ClearForm()
        {
            try
            {
                _repository.Clear();
                _grid.Clear();
                _view.ResetForm();
                _console.Clear();
            }
            catch (Exception ex)
            {
                _console.Write(string.Format("Clear error: {0}\n", ex.Message), Color.Red);
            }
        }
    }
}
