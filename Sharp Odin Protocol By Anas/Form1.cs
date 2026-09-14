using System;
using System.Windows.Forms;
using Sharp_Odin_Protocol_By_Anas.Controllers;
using Sharp_Odin_Protocol_By_Anas.UI;

namespace Sharp_Odin_Protocol_By_Anas
{
    public partial class Form1 : Form
    {
        private FlashController _controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _controller = new FlashController(CreateView());
        }

        private FlashView CreateView()
        {
            return new FlashView
            {
                LogBox = Log,
                ProgressBar = ProgreesBar,
                PartGrid = dataGridPart,
                PitPath = txtPIT,
                BlPath = txtFlashBL,
                ApPath = txtFlashAP,
                CpPath = txtFlashCP,
                CscPath = txtFlashCSC,
                Repartition = cbRepart,
                AutoReboot = cbFlashReboot,
                UpdateBoot = cbFlashUPboot,
                ClearEfs = cbFlashEFSErase,
                PitButton = btnPIT,
                OpenBl = buttonFlashOpenBL,
                OpenAp = buttonFlashOpenAP,
                OpenCp = buttonFlashOpenCP,
                OpenCsc = buttonFlashOpenCSC,
                FlashButton = buttonFlash,
                ReadPitButton = btnReadPIT,
                ClearButton = buttonFlashClearForm
            };
        }

        private void Panel_Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowChromeHelper.Drag(this);
            }
        }

        private void btnPIT_Click(object sender, EventArgs e)
        {
            _controller.SelectPit();
        }

        private void buttonFlashOpenBL_Click(object sender, EventArgs e)
        {
            _controller.OpenPackage("BL");
        }

        private void buttonFlashOpenAP_Click(object sender, EventArgs e)
        {
            _controller.OpenPackage("AP");
        }

        private void buttonFlashOpenCP_Click(object sender, EventArgs e)
        {
            _controller.OpenPackage("CP");
        }

        private void buttonFlashOpenCSC_Click(object sender, EventArgs e)
        {
            _controller.OpenPackage("CSC");
        }

        private async void buttonFlash_Click(object sender, EventArgs e)
        {
            Log.Clear();
            await _controller.StartFlash();
        }

        private async void btnReadPIT_Click(object sender, EventArgs e)
        {
            await _controller.ReadPit();
        }

        private void buttonFlashClearForm_Click(object sender, EventArgs e)
        {
            _controller.ClearForm();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimized_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
