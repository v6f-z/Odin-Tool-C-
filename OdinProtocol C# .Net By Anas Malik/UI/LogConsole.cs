using System;
using System.Drawing;
using System.Windows.Forms;

namespace OdinProtocol_C_.Net_By_Anas_Malik.UI
{
    public sealed class LogConsole
    {
        private readonly RichTextBox _output;

        public LogConsole(RichTextBox output)
        {
            _output = output;
        }

        public void Write(string text, Color color)
        {
            if (_output.InvokeRequired)
            {
                _output.Invoke(new Action(() => Write(text, color)));
                return;
            }

            _output.SelectionStart = _output.TextLength;
            _output.SelectionLength = 0;
            _output.SelectionColor = color;
            _output.AppendText(text);
            _output.SelectionColor = _output.ForeColor;
            _output.ScrollToCaret();
        }

        public void Clear()
        {
            if (_output.InvokeRequired)
            {
                _output.Invoke(new Action(Clear));
                return;
            }

            _output.Clear();
        }
    }
}
