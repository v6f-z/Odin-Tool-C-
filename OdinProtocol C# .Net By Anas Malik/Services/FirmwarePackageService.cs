using System.Collections.Generic;
using System.IO;
using OdinProtocol_C_.Net_By_Anas_Malik.Flash;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Services
{
    public sealed class FirmwarePackageService
    {
        private readonly FlashManager _flashManager;

        public FirmwarePackageService(FlashManager flashManager)
        {
            _flashManager = flashManager;
        }

        public PitSelectionResult SelectPit(string path)
        {
            string extension = Path.GetExtension(path).ToLower();

            if (extension == ".pit")
            {
                bool valid = _flashManager.ValidatePit(path);
                string fileName = Path.GetFileName(path);

                return new PitSelectionResult
                {
                    HasPit = true,
                    Valid = valid,
                    Message = valid
                        ? string.Format("PIT loaded: {0}\n", fileName)
                        : "Invalid PIT file!\n"
                };
            }

            string pitName = _flashManager.FindPitInTar(path);

            if (string.IsNullOrEmpty(pitName))
            {
                return new PitSelectionResult
                {
                    HasPit = false,
                    Valid = false,
                    Message = "No PIT file found in this package.\n"
                };
            }

            bool validInTar = _flashManager.ValidatePit(path, pitName);

            return new PitSelectionResult
            {
                HasPit = true,
                Valid = validInTar,
                Message = validInTar
                    ? string.Format("PIT found in TAR: {0}\n", pitName)
                    : "Invalid PIT inside TAR!\n"
            };
        }

        public List<FlashFileItem> OpenPackage(string path, string packageType)
        {
            return _flashManager.ReadTarFile(path, packageType);
        }
    }
}
