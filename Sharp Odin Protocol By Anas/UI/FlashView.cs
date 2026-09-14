using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Sharp_Odin_Protocol_By_Anas.Flash;
using Sharp_Odin_Protocol_By_Anas.Services;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public sealed class FlashView
    {
        public RichTextBox LogBox { get; set; }
        public Guna2ProgressBar ProgressBar { get; set; }
        public DataGridView PartGrid { get; set; }

        public Guna2TextBox PitPath { get; set; }
        public Guna2TextBox BlPath { get; set; }
        public Guna2TextBox ApPath { get; set; }
        public Guna2TextBox CpPath { get; set; }
        public Guna2TextBox CscPath { get; set; }

        public Guna2CheckBox Repartition { get; set; }
        public Guna2CheckBox AutoReboot { get; set; }
        public Guna2CheckBox UpdateBoot { get; set; }
        public Guna2CheckBox ClearEfs { get; set; }

        public Guna2Button PitButton { get; set; }
        public Guna2Button OpenBl { get; set; }
        public Guna2Button OpenAp { get; set; }
        public Guna2Button OpenCp { get; set; }
        public Guna2Button OpenCsc { get; set; }
        public Guna2Button FlashButton { get; set; }
        public Guna2Button ReadPitButton { get; set; }
        public Guna2Button ClearButton { get; set; }

        public FlashOptions BuildOptions(IList<FlashFileItem> files)
        {
            return new FlashOptions
            {
                BlPath = BlPath.Text,
                ApPath = ApPath.Text,
                CpPath = CpPath.Text,
                CscPath = CscPath.Text,
                PitPath = PitPath.Text,
                Repartition = Repartition.Checked,
                UpdateBoot = UpdateBoot.Checked,
                ClearEfs = ClearEfs.Checked,
                AutoReboot = AutoReboot.Checked,
                Files = new List<FlashFileItem>(files)
            };
        }

        public void ResetForm()
        {
            PitPath.Clear();
            BlPath.Clear();
            ApPath.Clear();
            CpPath.Clear();
            CscPath.Clear();
            AutoReboot.Checked = true;
            Repartition.Checked = false;
            UpdateBoot.Checked = false;
            ClearEfs.Checked = false;
        }
    }
}
