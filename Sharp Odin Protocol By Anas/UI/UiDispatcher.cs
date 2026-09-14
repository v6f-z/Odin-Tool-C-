using System;
using System.Windows.Forms;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public static class UiDispatcher
    {
        public static void RunOnUi(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
