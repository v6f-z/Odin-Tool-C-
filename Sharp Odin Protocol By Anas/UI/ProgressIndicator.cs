using Guna.UI2.WinForms;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public sealed class ProgressIndicator
    {
        private readonly Guna2ProgressBar _bar;

        public ProgressIndicator(Guna2ProgressBar bar)
        {
            _bar = bar;
        }

        public void Update(string fileName, long max, long value)
        {
            if (max <= 0)
            {
                return;
            }

            int percent = (int)((value * 100) / max);
            _bar.Value = percent < 0 ? 0 : (percent > 100 ? 100 : percent);
            _bar.Text = string.Format("{0}% - {1}", _bar.Value, fileName);
        }
    }
}
