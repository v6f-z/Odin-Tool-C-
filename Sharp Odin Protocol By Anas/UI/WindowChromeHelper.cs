using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public static class WindowChromeHelper
    {
        private const int WmNclButtonDown = 161;
        private const int HtCaption = 2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public static void Drag(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, WmNclButtonDown, HtCaption, 0);
        }
    }
}
