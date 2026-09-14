using System.Collections.Generic;
using OdinProtocol_C_.Net_By_Anas_Malik.Flash;

namespace OdinProtocol_C_.Net_By_Anas_Malik.Services
{
    public sealed class FlashOptions
    {
        public string BlPath { get; set; }
        public string ApPath { get; set; }
        public string CpPath { get; set; }
        public string CscPath { get; set; }
        public string PitPath { get; set; }
        public bool Repartition { get; set; }
        public bool UpdateBoot { get; set; }
        public bool ClearEfs { get; set; }
        public bool AutoReboot { get; set; }
        public List<FlashFileItem> Files { get; set; }
    }
}
