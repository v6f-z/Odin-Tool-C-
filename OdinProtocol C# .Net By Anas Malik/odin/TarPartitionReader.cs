using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpOdinClient;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Flash
{
    public class TarPartitionReader
    {
        private readonly Odin _odin;

        public event Action<string, string> OnPitDetected;
        public event Action<string, bool> OnLog;

        public TarPartitionReader()
        {
            _odin = new Odin();
        }

        public List<FlashFileItem> ReadTarContents(string tarPath, string packageType)
        {
            var files = new List<FlashFileItem>();

            try
            {
                if (string.IsNullOrEmpty(tarPath) || !File.Exists(tarPath))
                {
                    OnLog?.Invoke("File not found: " + tarPath, true);
                    return files;
                }

                var tarItems = _odin.tar.TarInformation(tarPath);

                if (tarItems == null || tarItems.Count == 0)
                {
                    OnLog?.Invoke(
                        "No files found inside: " + Path.GetFileName(tarPath),
                        true);

                    return files;
                }

                foreach (var item in tarItems)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.Filename))
                        continue;

                    string extension = Path
                        .GetExtension(item.Filename)
                        .ToLowerInvariant();

                    if (extension == ".pit")
                    {
                        OnPitDetected?.Invoke(item.Filename, tarPath);
                        continue;
                    }

                    if (extension != ".lz4")
                        continue;

                    long rawSize;

                    try
                    {
                        rawSize = _odin.CalculateLz4SizeFromTar(
                            tarPath,
                            item.Filename);
                    }
                    catch
                    {
                        rawSize = item.Filesize;
                    }

                    var file = new FlashFileItem
                    {
                        Enable = true,
                        FileName = item.Filename,
                        FilePath = tarPath,
                        RawSize = rawSize,
                        PackageType = packageType
                    };

                    files.Add(file);
                }

                OnLog?.Invoke(
                    "Loaded " +
                    files.Count +
                    " LZ4 files from " +
                    Path.GetFileName(tarPath) +
                    " (" +
                    packageType +
                    ")",
                    false);
            }
            catch (Exception ex)
            {
                OnLog?.Invoke(
                    "Error reading TAR: " + ex.Message,
                    true);
            }

            return files;
        }

        public bool ValidatePitFile(string pitPath, string pitFileName = null)
        {
            try
            {
                byte[] pitData;

                if (!string.IsNullOrEmpty(pitFileName) && Path.GetExtension(pitPath).ToLower() != ".pit")
                {
                    var extractTask = _odin.tar.ExtractFileFromTar(pitPath, pitFileName);
                    pitData = extractTask.GetAwaiter().GetResult();

                    if (pitData == null || pitData.Length == 0)
                    {
                        OnLog?.Invoke("Failed to extract PIT from TAR", true);
                        return false;
                    }
                }
                else
                {
                    pitData = File.ReadAllBytes(pitPath);
                }

                bool isValid = _odin.PitTool.UNPACK_PIT(pitData);
                if (isValid)
                {
                    OnLog?.Invoke("PIT validated: " + Path.GetFileName(pitPath), false);
                }
                else
                {
                    string name = pitFileName ?? pitPath;
                    OnLog?.Invoke("Invalid PIT: " + name, true);
                }

                return isValid;
            }
            catch (Exception ex)
            {
                OnLog?.Invoke("PIT error: " + ex.Message, true);
                return false;
            }
        }

        public string FindPitInTar(string tarPath)
        {
            try
            {
                var items = _odin.tar.TarInformation(tarPath);
                var pitFile = items.FirstOrDefault(x => Path.GetExtension(x.Filename).ToLower() == ".pit");
                return pitFile?.Filename;
            }
            catch
            {
                return null;
            }
        }
    }
}