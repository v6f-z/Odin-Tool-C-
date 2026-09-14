namespace OdinProtocol_C_.Net_By_Anas_Malik
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel_Home = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtPIT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtFlashCSC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFlashCP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFlashAP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFlashBL = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridPart = new System.Windows.Forms.DataGridView();
            this.cbRepart = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbFlashEFSErase = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbFlashUPboot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbFlashReboot = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ProgreesBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimized_Button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnReadPIT = new Guna.UI2.WinForms.Guna2Button();
            this.Close_Button = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonFlash = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonFlashClearForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnPIT = new Guna.UI2.WinForms.Guna2Button();
            this.buttonFlashOpenBL = new Guna.UI2.WinForms.Guna2Button();
            this.buttonFlashOpenCSC = new Guna.UI2.WinForms.Guna2Button();
            this.buttonFlashOpenAP = new Guna.UI2.WinForms.Guna2Button();
            this.buttonFlashOpenCP = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_Home.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPart)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 19;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Panel_Home
            // 
            this.Panel_Home.Controls.Add(this.label1);
            this.Panel_Home.Controls.Add(this.guna2PictureBox1);
            this.Panel_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Home.Location = new System.Drawing.Point(8, 5);
            this.Panel_Home.Name = "Panel_Home";
            this.Panel_Home.Size = new System.Drawing.Size(733, 37);
            this.Panel_Home.TabIndex = 2;
            this.Panel_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Home_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(62, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Samsung Advanced Flasher";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.Panel1.BorderThickness = 2;
            this.Panel1.Controls.Add(this.Log);
            this.Panel1.Location = new System.Drawing.Point(589, 47);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(235, 437);
            this.Panel1.TabIndex = 27;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Location = new System.Drawing.Point(3, 3);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(229, 431);
            this.Log.TabIndex = 0;
            this.Log.Text = "";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.label40.Location = new System.Drawing.Point(8, 56);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 23);
            this.label40.TabIndex = 74;
            this.label40.Text = "PIT";
            // 
            // txtPIT
            // 
            this.txtPIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPIT.Animated = true;
            this.txtPIT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtPIT.BorderRadius = 10;
            this.txtPIT.BorderThickness = 2;
            this.txtPIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPIT.DefaultText = "";
            this.txtPIT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.txtPIT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtPIT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIT.Location = new System.Drawing.Point(61, 56);
            this.txtPIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPIT.Name = "txtPIT";
            this.txtPIT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPIT.PlaceholderText = "PIT File";
            this.txtPIT.ReadOnly = true;
            this.txtPIT.SelectedText = "";
            this.txtPIT.Size = new System.Drawing.Size(445, 26);
            this.txtPIT.TabIndex = 73;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.DarkOrange;
            this.label39.Location = new System.Drawing.Point(8, 194);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 23);
            this.label39.TabIndex = 68;
            this.label39.Text = "CSC";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.DarkOrange;
            this.label38.Location = new System.Drawing.Point(8, 157);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 23);
            this.label38.TabIndex = 67;
            this.label38.Text = "CP";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.DarkOrange;
            this.label36.Location = new System.Drawing.Point(8, 123);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 23);
            this.label36.TabIndex = 66;
            this.label36.Text = "AP";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DarkOrange;
            this.label35.Location = new System.Drawing.Point(8, 90);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 23);
            this.label35.TabIndex = 65;
            this.label35.Text = "BL";
            // 
            // txtFlashCSC
            // 
            this.txtFlashCSC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlashCSC.Animated = true;
            this.txtFlashCSC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashCSC.BorderRadius = 10;
            this.txtFlashCSC.BorderThickness = 2;
            this.txtFlashCSC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlashCSC.DefaultText = "";
            this.txtFlashCSC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFlashCSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFlashCSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashCSC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashCSC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.txtFlashCSC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashCSC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFlashCSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashCSC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashCSC.Location = new System.Drawing.Point(61, 191);
            this.txtFlashCSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashCSC.Name = "txtFlashCSC";
            this.txtFlashCSC.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFlashCSC.PlaceholderText = "Select CSC file package [tar,md5] Package";
            this.txtFlashCSC.ReadOnly = true;
            this.txtFlashCSC.SelectedText = "";
            this.txtFlashCSC.Size = new System.Drawing.Size(445, 26);
            this.txtFlashCSC.TabIndex = 64;
            // 
            // txtFlashCP
            // 
            this.txtFlashCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlashCP.Animated = true;
            this.txtFlashCP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashCP.BorderRadius = 10;
            this.txtFlashCP.BorderThickness = 2;
            this.txtFlashCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlashCP.DefaultText = "";
            this.txtFlashCP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFlashCP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFlashCP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashCP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashCP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.txtFlashCP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFlashCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashCP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashCP.Location = new System.Drawing.Point(61, 157);
            this.txtFlashCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashCP.Name = "txtFlashCP";
            this.txtFlashCP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFlashCP.PlaceholderText = "Select CP (Modem) file package [tar,md5] Package";
            this.txtFlashCP.ReadOnly = true;
            this.txtFlashCP.SelectedText = "";
            this.txtFlashCP.Size = new System.Drawing.Size(445, 26);
            this.txtFlashCP.TabIndex = 63;
            // 
            // txtFlashAP
            // 
            this.txtFlashAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlashAP.Animated = true;
            this.txtFlashAP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashAP.BorderRadius = 10;
            this.txtFlashAP.BorderThickness = 2;
            this.txtFlashAP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlashAP.DefaultText = "";
            this.txtFlashAP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFlashAP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFlashAP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashAP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashAP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.txtFlashAP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashAP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFlashAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashAP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashAP.Location = new System.Drawing.Point(61, 123);
            this.txtFlashAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashAP.Name = "txtFlashAP";
            this.txtFlashAP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFlashAP.PlaceholderText = "Select AP (PDA) file package [tar,md5] Package";
            this.txtFlashAP.ReadOnly = true;
            this.txtFlashAP.SelectedText = "";
            this.txtFlashAP.Size = new System.Drawing.Size(445, 26);
            this.txtFlashAP.TabIndex = 62;
            // 
            // txtFlashBL
            // 
            this.txtFlashBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlashBL.Animated = true;
            this.txtFlashBL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashBL.BorderRadius = 10;
            this.txtFlashBL.BorderThickness = 2;
            this.txtFlashBL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFlashBL.DefaultText = "";
            this.txtFlashBL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFlashBL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFlashBL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashBL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFlashBL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.txtFlashBL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFlashBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtFlashBL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFlashBL.Location = new System.Drawing.Point(61, 90);
            this.txtFlashBL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlashBL.Name = "txtFlashBL";
            this.txtFlashBL.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFlashBL.PlaceholderText = "Select BL (bootloader) file package [tar,md5] Package";
            this.txtFlashBL.ReadOnly = true;
            this.txtFlashBL.SelectedText = "";
            this.txtFlashBL.Size = new System.Drawing.Size(445, 26);
            this.txtFlashBL.TabIndex = 61;
            // 
            // dataGridPart
            // 
            this.dataGridPart.AllowUserToAddRows = false;
            this.dataGridPart.AllowUserToDeleteRows = false;
            this.dataGridPart.AllowUserToResizeColumns = false;
            this.dataGridPart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dataGridPart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPart.ColumnHeadersHeight = 32;
            this.dataGridPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPart.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridPart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dataGridPart.Location = new System.Drawing.Point(7, 222);
            this.dataGridPart.MultiSelect = false;
            this.dataGridPart.Name = "dataGridPart";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPart.RowHeadersVisible = false;
            this.dataGridPart.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPart.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridPart.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridPart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridPart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridPart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dataGridPart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dataGridPart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPart.Size = new System.Drawing.Size(578, 242);
            this.dataGridPart.TabIndex = 76;
            // 
            // cbRepart
            // 
            this.cbRepart.Animated = true;
            this.cbRepart.AutoSize = true;
            this.cbRepart.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbRepart.CheckedState.BorderRadius = 0;
            this.cbRepart.CheckedState.BorderThickness = 0;
            this.cbRepart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbRepart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cbRepart.Location = new System.Drawing.Point(166, 480);
            this.cbRepart.Name = "cbRepart";
            this.cbRepart.Size = new System.Drawing.Size(115, 25);
            this.cbRepart.TabIndex = 82;
            this.cbRepart.Text = "Repartition";
            this.cbRepart.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbRepart.UncheckedState.BorderRadius = 0;
            this.cbRepart.UncheckedState.BorderThickness = 0;
            this.cbRepart.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbFlashEFSErase
            // 
            this.cbFlashEFSErase.Animated = true;
            this.cbFlashEFSErase.AutoSize = true;
            this.cbFlashEFSErase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashEFSErase.CheckedState.BorderRadius = 0;
            this.cbFlashEFSErase.CheckedState.BorderThickness = 0;
            this.cbFlashEFSErase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashEFSErase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlashEFSErase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cbFlashEFSErase.Location = new System.Drawing.Point(478, 480);
            this.cbFlashEFSErase.Name = "cbFlashEFSErase";
            this.cbFlashEFSErase.Size = new System.Drawing.Size(98, 25);
            this.cbFlashEFSErase.TabIndex = 80;
            this.cbFlashEFSErase.Text = "Clear EFS";
            this.cbFlashEFSErase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbFlashEFSErase.UncheckedState.BorderRadius = 0;
            this.cbFlashEFSErase.UncheckedState.BorderThickness = 0;
            this.cbFlashEFSErase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbFlashUPboot
            // 
            this.cbFlashUPboot.Animated = true;
            this.cbFlashUPboot.AutoSize = true;
            this.cbFlashUPboot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashUPboot.CheckedState.BorderRadius = 0;
            this.cbFlashUPboot.CheckedState.BorderThickness = 0;
            this.cbFlashUPboot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashUPboot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlashUPboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cbFlashUPboot.Location = new System.Drawing.Point(300, 480);
            this.cbFlashUPboot.Name = "cbFlashUPboot";
            this.cbFlashUPboot.Size = new System.Drawing.Size(131, 25);
            this.cbFlashUPboot.TabIndex = 79;
            this.cbFlashUPboot.Text = "Update BOOT";
            this.cbFlashUPboot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbFlashUPboot.UncheckedState.BorderRadius = 0;
            this.cbFlashUPboot.UncheckedState.BorderThickness = 0;
            this.cbFlashUPboot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbFlashReboot
            // 
            this.cbFlashReboot.Animated = true;
            this.cbFlashReboot.AutoSize = true;
            this.cbFlashReboot.Checked = true;
            this.cbFlashReboot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashReboot.CheckedState.BorderRadius = 0;
            this.cbFlashReboot.CheckedState.BorderThickness = 0;
            this.cbFlashReboot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.cbFlashReboot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFlashReboot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlashReboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cbFlashReboot.Location = new System.Drawing.Point(30, 480);
            this.cbFlashReboot.Name = "cbFlashReboot";
            this.cbFlashReboot.Size = new System.Drawing.Size(125, 25);
            this.cbFlashReboot.TabIndex = 78;
            this.cbFlashReboot.Text = "Auto Reboot";
            this.cbFlashReboot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbFlashReboot.UncheckedState.BorderRadius = 0;
            this.cbFlashReboot.UncheckedState.BorderThickness = 0;
            this.cbFlashReboot.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ProgreesBar
            // 
            this.ProgreesBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgreesBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.ProgreesBar.BorderRadius = 2;
            this.ProgreesBar.BorderThickness = 2;
            this.ProgreesBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ProgreesBar.ForeColor = System.Drawing.Color.White;
            this.ProgreesBar.Location = new System.Drawing.Point(589, 501);
            this.ProgreesBar.Name = "ProgreesBar";
            this.ProgreesBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.ProgreesBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ProgreesBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.ProgreesBar.Size = new System.Drawing.Size(235, 38);
            this.ProgreesBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgreesBar.TabIndex = 84;
            this.ProgreesBar.Text = "Guna2ProgressBar1";
            this.ProgreesBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.Minimized_Button);
            this.guna2Panel1.Controls.Add(this.btnReadPIT);
            this.guna2Panel1.Controls.Add(this.ProgreesBar);
            this.guna2Panel1.Controls.Add(this.cbRepart);
            this.guna2Panel1.Controls.Add(this.Close_Button);
            this.guna2Panel1.Controls.Add(this.buttonFlash);
            this.guna2Panel1.Controls.Add(this.Panel_Home);
            this.guna2Panel1.Controls.Add(this.cbFlashEFSErase);
            this.guna2Panel1.Controls.Add(this.txtPIT);
            this.guna2Panel1.Controls.Add(this.cbFlashUPboot);
            this.guna2Panel1.Controls.Add(this.txtFlashBL);
            this.guna2Panel1.Controls.Add(this.cbFlashReboot);
            this.guna2Panel1.Controls.Add(this.txtFlashAP);
            this.guna2Panel1.Controls.Add(this.buttonFlashClearForm);
            this.guna2Panel1.Controls.Add(this.txtFlashCP);
            this.guna2Panel1.Controls.Add(this.txtFlashCSC);
            this.guna2Panel1.Controls.Add(this.label35);
            this.guna2Panel1.Controls.Add(this.dataGridPart);
            this.guna2Panel1.Controls.Add(this.label36);
            this.guna2Panel1.Controls.Add(this.Panel1);
            this.guna2Panel1.Controls.Add(this.btnPIT);
            this.guna2Panel1.Controls.Add(this.label38);
            this.guna2Panel1.Controls.Add(this.label40);
            this.guna2Panel1.Controls.Add(this.label39);
            this.guna2Panel1.Controls.Add(this.buttonFlashOpenBL);
            this.guna2Panel1.Controls.Add(this.buttonFlashOpenCSC);
            this.guna2Panel1.Controls.Add(this.buttonFlashOpenAP);
            this.guna2Panel1.Controls.Add(this.buttonFlashOpenCP);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(834, 559);
            this.guna2Panel1.TabIndex = 28;
            // 
            // Minimized_Button
            // 
            this.Minimized_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized_Button.FillColor = System.Drawing.Color.Transparent;
            this.Minimized_Button.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.exit_full_screen;
            this.Minimized_Button.ImageRotate = 0F;
            this.Minimized_Button.Location = new System.Drawing.Point(748, 9);
            this.Minimized_Button.Name = "Minimized_Button";
            this.Minimized_Button.Size = new System.Drawing.Size(30, 29);
            this.Minimized_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimized_Button.TabIndex = 1;
            this.Minimized_Button.TabStop = false;
            this.Minimized_Button.Click += new System.EventHandler(this.Minimized_Button_Click);
            // 
            // btnReadPIT
            // 
            this.btnReadPIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadPIT.Animated = true;
            this.btnReadPIT.BackColor = System.Drawing.Color.Transparent;
            this.btnReadPIT.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnReadPIT.BorderRadius = 15;
            this.btnReadPIT.BorderThickness = 2;
            this.btnReadPIT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReadPIT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReadPIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReadPIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReadPIT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReadPIT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReadPIT.ForeColor = System.Drawing.Color.White;
            this.btnReadPIT.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.pit;
            this.btnReadPIT.ImageSize = new System.Drawing.Size(27, 27);
            this.btnReadPIT.Location = new System.Drawing.Point(273, 512);
            this.btnReadPIT.Name = "btnReadPIT";
            this.btnReadPIT.Size = new System.Drawing.Size(152, 33);
            this.btnReadPIT.TabIndex = 83;
            this.btnReadPIT.Text = "Read PIT";
            this.btnReadPIT.Click += new System.EventHandler(this.btnReadPIT_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FillColor = System.Drawing.Color.Transparent;
            this.Close_Button.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.close;
            this.Close_Button.ImageRotate = 0F;
            this.Close_Button.Location = new System.Drawing.Point(785, 5);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(38, 37);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_Button.TabIndex = 0;
            this.Close_Button.TabStop = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // buttonFlash
            // 
            this.buttonFlash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlash.Animated = true;
            this.buttonFlash.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlash.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlash.BorderRadius = 15;
            this.buttonFlash.BorderThickness = 2;
            this.buttonFlash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFlash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlash.ForeColor = System.Drawing.Color.White;
            this.buttonFlash.Image = ((System.Drawing.Image)(resources.GetObject("buttonFlash.Image")));
            this.buttonFlash.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonFlash.Location = new System.Drawing.Point(15, 512);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(253, 33);
            this.buttonFlash.TabIndex = 81;
            this.buttonFlash.Text = "Flash";
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.odin;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(54, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // buttonFlashClearForm
            // 
            this.buttonFlashClearForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlashClearForm.Animated = true;
            this.buttonFlashClearForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlashClearForm.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlashClearForm.BorderRadius = 15;
            this.buttonFlashClearForm.BorderThickness = 2;
            this.buttonFlashClearForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashClearForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashClearForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlashClearForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlashClearForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFlashClearForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlashClearForm.ForeColor = System.Drawing.Color.White;
            this.buttonFlashClearForm.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.clear;
            this.buttonFlashClearForm.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonFlashClearForm.Location = new System.Drawing.Point(431, 512);
            this.buttonFlashClearForm.Name = "buttonFlashClearForm";
            this.buttonFlashClearForm.Size = new System.Drawing.Size(152, 33);
            this.buttonFlashClearForm.TabIndex = 77;
            this.buttonFlashClearForm.Text = "Clear";
            this.buttonFlashClearForm.Click += new System.EventHandler(this.buttonFlashClearForm_Click);
            // 
            // btnPIT
            // 
            this.btnPIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPIT.Animated = true;
            this.btnPIT.BackColor = System.Drawing.Color.Transparent;
            this.btnPIT.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnPIT.BorderRadius = 12;
            this.btnPIT.BorderThickness = 2;
            this.btnPIT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPIT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPIT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnPIT.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnPIT.ForeColor = System.Drawing.Color.White;
            this.btnPIT.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.file;
            this.btnPIT.Location = new System.Drawing.Point(513, 55);
            this.btnPIT.Name = "btnPIT";
            this.btnPIT.Size = new System.Drawing.Size(70, 26);
            this.btnPIT.TabIndex = 75;
            this.btnPIT.Click += new System.EventHandler(this.btnPIT_Click);
            // 
            // buttonFlashOpenBL
            // 
            this.buttonFlashOpenBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlashOpenBL.Animated = true;
            this.buttonFlashOpenBL.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlashOpenBL.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlashOpenBL.BorderRadius = 12;
            this.buttonFlashOpenBL.BorderThickness = 2;
            this.buttonFlashOpenBL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenBL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenBL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlashOpenBL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlashOpenBL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonFlashOpenBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlashOpenBL.ForeColor = System.Drawing.Color.White;
            this.buttonFlashOpenBL.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.file;
            this.buttonFlashOpenBL.Location = new System.Drawing.Point(513, 89);
            this.buttonFlashOpenBL.Name = "buttonFlashOpenBL";
            this.buttonFlashOpenBL.Size = new System.Drawing.Size(70, 26);
            this.buttonFlashOpenBL.TabIndex = 69;
            this.buttonFlashOpenBL.Click += new System.EventHandler(this.buttonFlashOpenBL_Click);
            // 
            // buttonFlashOpenCSC
            // 
            this.buttonFlashOpenCSC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlashOpenCSC.Animated = true;
            this.buttonFlashOpenCSC.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlashOpenCSC.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlashOpenCSC.BorderRadius = 12;
            this.buttonFlashOpenCSC.BorderThickness = 2;
            this.buttonFlashOpenCSC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenCSC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenCSC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlashOpenCSC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlashOpenCSC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonFlashOpenCSC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlashOpenCSC.ForeColor = System.Drawing.Color.White;
            this.buttonFlashOpenCSC.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.file;
            this.buttonFlashOpenCSC.Location = new System.Drawing.Point(513, 191);
            this.buttonFlashOpenCSC.Name = "buttonFlashOpenCSC";
            this.buttonFlashOpenCSC.Size = new System.Drawing.Size(70, 26);
            this.buttonFlashOpenCSC.TabIndex = 72;
            this.buttonFlashOpenCSC.Click += new System.EventHandler(this.buttonFlashOpenCSC_Click);
            // 
            // buttonFlashOpenAP
            // 
            this.buttonFlashOpenAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlashOpenAP.Animated = true;
            this.buttonFlashOpenAP.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlashOpenAP.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlashOpenAP.BorderRadius = 12;
            this.buttonFlashOpenAP.BorderThickness = 2;
            this.buttonFlashOpenAP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenAP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenAP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlashOpenAP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlashOpenAP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonFlashOpenAP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlashOpenAP.ForeColor = System.Drawing.Color.White;
            this.buttonFlashOpenAP.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.file;
            this.buttonFlashOpenAP.Location = new System.Drawing.Point(513, 125);
            this.buttonFlashOpenAP.Name = "buttonFlashOpenAP";
            this.buttonFlashOpenAP.Size = new System.Drawing.Size(70, 26);
            this.buttonFlashOpenAP.TabIndex = 70;
            this.buttonFlashOpenAP.Click += new System.EventHandler(this.buttonFlashOpenAP_Click);
            // 
            // buttonFlashOpenCP
            // 
            this.buttonFlashOpenCP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFlashOpenCP.Animated = true;
            this.buttonFlashOpenCP.BackColor = System.Drawing.Color.Transparent;
            this.buttonFlashOpenCP.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFlashOpenCP.BorderRadius = 12;
            this.buttonFlashOpenCP.BorderThickness = 2;
            this.buttonFlashOpenCP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenCP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFlashOpenCP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFlashOpenCP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFlashOpenCP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonFlashOpenCP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlashOpenCP.ForeColor = System.Drawing.Color.White;
            this.buttonFlashOpenCP.Image = global::OdinProtocol_C_.Net_By_Anas_Malik.Properties.Resources.file;
            this.buttonFlashOpenCP.Location = new System.Drawing.Point(513, 157);
            this.buttonFlashOpenCP.Name = "buttonFlashOpenCP";
            this.buttonFlashOpenCP.Size = new System.Drawing.Size(70, 26);
            this.buttonFlashOpenCP.TabIndex = 71;
            this.buttonFlashOpenCP.Click += new System.EventHandler(this.buttonFlashOpenCP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(838, 563);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Home.ResumeLayout(false);
            this.Panel_Home.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPart)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox Close_Button;
        private Guna.UI2.WinForms.Guna2Panel Panel_Home;
        private Guna.UI2.WinForms.Guna2PictureBox Minimized_Button;
        internal Guna.UI2.WinForms.Guna2Button btnPIT;
        private System.Windows.Forms.Label label40;
        internal Guna.UI2.WinForms.Guna2TextBox txtPIT;
        internal Guna.UI2.WinForms.Guna2Button buttonFlashOpenCSC;
        internal Guna.UI2.WinForms.Guna2Button buttonFlashOpenCP;
        internal Guna.UI2.WinForms.Guna2Button buttonFlashOpenAP;
        internal Guna.UI2.WinForms.Guna2Button buttonFlashOpenBL;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        internal Guna.UI2.WinForms.Guna2TextBox txtFlashCSC;
        internal Guna.UI2.WinForms.Guna2TextBox txtFlashCP;
        internal Guna.UI2.WinForms.Guna2TextBox txtFlashAP;
        internal Guna.UI2.WinForms.Guna2TextBox txtFlashBL;
        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private System.Windows.Forms.RichTextBox Log;
        internal System.Windows.Forms.DataGridView dataGridPart;
        private Guna.UI2.WinForms.Guna2Button btnReadPIT;
        internal Guna.UI2.WinForms.Guna2CheckBox cbRepart;
        private Guna.UI2.WinForms.Guna2Button buttonFlash;
        internal Guna.UI2.WinForms.Guna2CheckBox cbFlashEFSErase;
        internal Guna.UI2.WinForms.Guna2CheckBox cbFlashUPboot;
        internal Guna.UI2.WinForms.Guna2CheckBox cbFlashReboot;
        private Guna.UI2.WinForms.Guna2Button buttonFlashClearForm;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgreesBar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

