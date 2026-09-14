using System.Windows.Forms;

namespace OdinProtocol_C_.Net_By_Anas_Malik.UI
{
    public sealed class FlashControlsState
    {
        private readonly Control[] _controls;

        public FlashControlsState(params Control[] controls)
        {
            _controls = controls;
        }

        public void SetEnabled(bool enabled)
        {
            foreach (var control in _controls)
            {
                control.Enabled = enabled;
            }
        }
    }
}
