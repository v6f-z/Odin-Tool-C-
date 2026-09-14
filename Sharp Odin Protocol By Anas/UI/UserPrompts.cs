using System.Windows.Forms;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public static class UserPrompts
    {
        public static string SelectPitFile()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "PIT or TAR file|*.tar;*.md5;*.pit";
                dialog.Title = "Select PIT File";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }

                return null;
            }
        }

        public static string SelectFirmwarePackage(string packageType)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Samsung Firmware|*.tar;*.md5;*.limra";
                dialog.Title = string.Format("Select {0} Package", packageType);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.FileName;
                }

                return null;
            }
        }

        public static bool ConfirmEfsClear()
        {
            DialogResult result = MessageBox.Show(
                "WARNING: Clearing EFS will erase IMEI, baseband, and network data!\n" +
                "This cannot be undone.\n\nContinue?",
                "EFS Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }
    }
}
