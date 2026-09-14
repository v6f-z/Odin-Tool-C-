using System.Collections.Generic;
using System.Linq;
using OdinProtocol_C_.Net_By_Anas_Malik.Flash;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Services
{
    public sealed class FirmwareRepository
    {
        private readonly List<FlashFileItem> _items = new List<FlashFileItem>();

        public List<FlashFileItem> All
        {
            get { return _items.ToList(); }
        }

        public void ReplacePackage(string packageType, IList<FlashFileItem> files)
        {
            var existing = _items.Where(x => x.PackageType == packageType).ToList();

            foreach (var item in existing)
            {
                _items.Remove(item);
            }

            _items.AddRange(files);
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
