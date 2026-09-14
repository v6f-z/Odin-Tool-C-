using System;
using System.Windows.Forms;

namespace OdinProtocol_C_.Net_By_Anas_Malik.UI
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
