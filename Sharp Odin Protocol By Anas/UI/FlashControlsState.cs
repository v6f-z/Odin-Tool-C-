using System.Windows.Forms;

namespace Sharp_Odin_Protocol_By_Anas.UI
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
