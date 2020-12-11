namespace DoAn
{
    partial class frmLIBRARIAN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLIBRARIAN));
            this.timer_Watch = new System.Windows.Forms.Timer(this.components);
            this.panelLIBRARIAN_Watch = new Guna.UI.WinForms.GunaPanel();
            this.lblWatch_Day = new System.Windows.Forms.Label();
            this.lblWatch_Date = new System.Windows.Forms.Label();
            this.lblWatch_Second = new System.Windows.Forms.Label();
            this.lblWatch_Time = new System.Windows.Forms.Label();
            this.panelLIBRARIAN_Menu = new Guna.UI.WinForms.GunaPanel();
            this.btnLIBRARIAN_Borrow = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLIBRARIAN_Book = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLIBRARIAN_Reader = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLIBRARIAN_LogOut = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLIBRARIAN_Exit = new Guna.UI.WinForms.GunaButton();
            this.lblLIBRARIAN_Manager = new Guna.UI.WinForms.GunaLabel();
            this.lblLIBRARIAN_UserName = new Guna.UI.WinForms.GunaLabel();
            this.pbLIBRARIAN_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.pbLIBRARIAN_Logo = new Guna.UI.WinForms.GunaPictureBox();
            this.panelLIBRARIAN_Header = new Guna.UI.WinForms.GunaPanel();
            this.panelLIBRARIAN_Watch.SuspendLayout();
            this.panelLIBRARIAN_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLIBRARIAN_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLIBRARIAN_Logo)).BeginInit();
            this.panelLIBRARIAN_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_Watch
            // 
            this.timer_Watch.Interval = 1000;
            this.timer_Watch.Tick += new System.EventHandler(this.timer_Watch_Tick);
            // 
            // panelLIBRARIAN_Watch
            // 
            this.panelLIBRARIAN_Watch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelLIBRARIAN_Watch.Controls.Add(this.lblWatch_Day);
            this.panelLIBRARIAN_Watch.Controls.Add(this.lblWatch_Date);
            this.panelLIBRARIAN_Watch.Controls.Add(this.lblWatch_Second);
            this.panelLIBRARIAN_Watch.Controls.Add(this.lblWatch_Time);
            this.panelLIBRARIAN_Watch.Location = new System.Drawing.Point(768, 0);
            this.panelLIBRARIAN_Watch.Name = "panelLIBRARIAN_Watch";
            this.panelLIBRARIAN_Watch.Size = new System.Drawing.Size(400, 100);
            this.panelLIBRARIAN_Watch.TabIndex = 0;
            // 
            // lblWatch_Day
            // 
            this.lblWatch_Day.AutoSize = true;
            this.lblWatch_Day.Font = new System.Drawing.Font("DS-Digital", 16.2F);
            this.lblWatch_Day.Location = new System.Drawing.Point(234, 62);
            this.lblWatch_Day.Name = "lblWatch_Day";
            this.lblWatch_Day.Size = new System.Drawing.Size(54, 28);
            this.lblWatch_Day.TabIndex = 3;
            this.lblWatch_Day.Text = "Day";
            // 
            // lblWatch_Date
            // 
            this.lblWatch_Date.AutoSize = true;
            this.lblWatch_Date.Font = new System.Drawing.Font("DS-Digital", 16.2F);
            this.lblWatch_Date.Location = new System.Drawing.Point(27, 62);
            this.lblWatch_Date.Name = "lblWatch_Date";
            this.lblWatch_Date.Size = new System.Drawing.Size(68, 28);
            this.lblWatch_Date.TabIndex = 2;
            this.lblWatch_Date.Text = "Date";
            // 
            // lblWatch_Second
            // 
            this.lblWatch_Second.AutoSize = true;
            this.lblWatch_Second.Font = new System.Drawing.Font("DS-Digital", 19.8F);
            this.lblWatch_Second.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWatch_Second.Location = new System.Drawing.Point(227, 7);
            this.lblWatch_Second.Name = "lblWatch_Second";
            this.lblWatch_Second.Size = new System.Drawing.Size(47, 33);
            this.lblWatch_Second.TabIndex = 1;
            this.lblWatch_Second.Text = "00";
            // 
            // lblWatch_Time
            // 
            this.lblWatch_Time.AutoSize = true;
            this.lblWatch_Time.Font = new System.Drawing.Font("DS-Digital", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatch_Time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWatch_Time.Location = new System.Drawing.Point(94, 0);
            this.lblWatch_Time.Name = "lblWatch_Time";
            this.lblWatch_Time.Size = new System.Drawing.Size(127, 47);
            this.lblWatch_Time.TabIndex = 0;
            this.lblWatch_Time.Text = "00:00";
            // 
            // panelLIBRARIAN_Menu
            // 
            this.panelLIBRARIAN_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelLIBRARIAN_Menu.Controls.Add(this.btnLIBRARIAN_Borrow);
            this.panelLIBRARIAN_Menu.Controls.Add(this.btnLIBRARIAN_Book);
            this.panelLIBRARIAN_Menu.Controls.Add(this.btnLIBRARIAN_Reader);
            this.panelLIBRARIAN_Menu.Controls.Add(this.btnLIBRARIAN_LogOut);
            this.panelLIBRARIAN_Menu.Location = new System.Drawing.Point(-1, 100);
            this.panelLIBRARIAN_Menu.Name = "panelLIBRARIAN_Menu";
            this.panelLIBRARIAN_Menu.Size = new System.Drawing.Size(160, 700);
            this.panelLIBRARIAN_Menu.TabIndex = 0;
            // 
            // btnLIBRARIAN_Borrow
            // 
            this.btnLIBRARIAN_Borrow.AnimationHoverSpeed = 0.07F;
            this.btnLIBRARIAN_Borrow.AnimationSpeed = 0.03F;
            this.btnLIBRARIAN_Borrow.BackColor = System.Drawing.Color.Transparent;
            this.btnLIBRARIAN_Borrow.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnLIBRARIAN_Borrow.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnLIBRARIAN_Borrow.BorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRARIAN_Borrow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLIBRARIAN_Borrow.FocusedColor = System.Drawing.Color.Empty;
            this.btnLIBRARIAN_Borrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLIBRARIAN_Borrow.ForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Borrow.Image = null;
            this.btnLIBRARIAN_Borrow.ImageSize = new System.Drawing.Size(50, 40);
            this.btnLIBRARIAN_Borrow.Location = new System.Drawing.Point(5, 200);
            this.btnLIBRARIAN_Borrow.Name = "btnLIBRARIAN_Borrow";
            this.btnLIBRARIAN_Borrow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLIBRARIAN_Borrow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLIBRARIAN_Borrow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Borrow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Borrow.OnHoverImage = null;
            this.btnLIBRARIAN_Borrow.OnPressedColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Borrow.Radius = 2;
            this.btnLIBRARIAN_Borrow.Size = new System.Drawing.Size(150, 95);
            this.btnLIBRARIAN_Borrow.TabIndex = 3;
            this.btnLIBRARIAN_Borrow.Text = "Borrow";
            this.btnLIBRARIAN_Borrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLIBRARIAN_Borrow.Click += new System.EventHandler(this.btnLIBRARIAN_Borrow_Click);
            // 
            // btnLIBRARIAN_Book
            // 
            this.btnLIBRARIAN_Book.AnimationHoverSpeed = 0.07F;
            this.btnLIBRARIAN_Book.AnimationSpeed = 0.03F;
            this.btnLIBRARIAN_Book.BackColor = System.Drawing.Color.Transparent;
            this.btnLIBRARIAN_Book.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnLIBRARIAN_Book.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnLIBRARIAN_Book.BorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRARIAN_Book.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLIBRARIAN_Book.FocusedColor = System.Drawing.Color.Empty;
            this.btnLIBRARIAN_Book.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLIBRARIAN_Book.ForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Book.Image = null;
            this.btnLIBRARIAN_Book.ImageSize = new System.Drawing.Size(50, 40);
            this.btnLIBRARIAN_Book.Location = new System.Drawing.Point(5, 0);
            this.btnLIBRARIAN_Book.Name = "btnLIBRARIAN_Book";
            this.btnLIBRARIAN_Book.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLIBRARIAN_Book.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLIBRARIAN_Book.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Book.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Book.OnHoverImage = null;
            this.btnLIBRARIAN_Book.OnPressedColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Book.Radius = 2;
            this.btnLIBRARIAN_Book.Size = new System.Drawing.Size(150, 95);
            this.btnLIBRARIAN_Book.TabIndex = 1;
            this.btnLIBRARIAN_Book.Text = "Book";
            this.btnLIBRARIAN_Book.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLIBRARIAN_Book.Click += new System.EventHandler(this.btnLIBRARIAN_Book_Click);
            // 
            // btnLIBRARIAN_Reader
            // 
            this.btnLIBRARIAN_Reader.AnimationHoverSpeed = 0.07F;
            this.btnLIBRARIAN_Reader.AnimationSpeed = 0.03F;
            this.btnLIBRARIAN_Reader.BackColor = System.Drawing.Color.Transparent;
            this.btnLIBRARIAN_Reader.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnLIBRARIAN_Reader.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnLIBRARIAN_Reader.BorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Reader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRARIAN_Reader.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLIBRARIAN_Reader.FocusedColor = System.Drawing.Color.Empty;
            this.btnLIBRARIAN_Reader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLIBRARIAN_Reader.ForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Reader.Image = null;
            this.btnLIBRARIAN_Reader.ImageSize = new System.Drawing.Size(50, 40);
            this.btnLIBRARIAN_Reader.Location = new System.Drawing.Point(5, 100);
            this.btnLIBRARIAN_Reader.Name = "btnLIBRARIAN_Reader";
            this.btnLIBRARIAN_Reader.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLIBRARIAN_Reader.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLIBRARIAN_Reader.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Reader.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Reader.OnHoverImage = null;
            this.btnLIBRARIAN_Reader.OnPressedColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Reader.Radius = 2;
            this.btnLIBRARIAN_Reader.Size = new System.Drawing.Size(150, 95);
            this.btnLIBRARIAN_Reader.TabIndex = 2;
            this.btnLIBRARIAN_Reader.Text = "Reader";
            this.btnLIBRARIAN_Reader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLIBRARIAN_Reader.Click += new System.EventHandler(this.btnLIBRARIAN_Reader_Click);
            // 
            // btnLIBRARIAN_LogOut
            // 
            this.btnLIBRARIAN_LogOut.AnimationHoverSpeed = 0.07F;
            this.btnLIBRARIAN_LogOut.AnimationSpeed = 0.03F;
            this.btnLIBRARIAN_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLIBRARIAN_LogOut.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnLIBRARIAN_LogOut.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnLIBRARIAN_LogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRARIAN_LogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLIBRARIAN_LogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLIBRARIAN_LogOut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLIBRARIAN_LogOut.ForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLIBRARIAN_LogOut.Image")));
            this.btnLIBRARIAN_LogOut.ImageSize = new System.Drawing.Size(28, 28);
            this.btnLIBRARIAN_LogOut.Location = new System.Drawing.Point(5, 640);
            this.btnLIBRARIAN_LogOut.Name = "btnLIBRARIAN_LogOut";
            this.btnLIBRARIAN_LogOut.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLIBRARIAN_LogOut.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLIBRARIAN_LogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_LogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_LogOut.OnHoverImage = null;
            this.btnLIBRARIAN_LogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_LogOut.Radius = 2;
            this.btnLIBRARIAN_LogOut.Size = new System.Drawing.Size(150, 55);
            this.btnLIBRARIAN_LogOut.TabIndex = 4;
            this.btnLIBRARIAN_LogOut.Text = "Logout";
            this.btnLIBRARIAN_LogOut.Click += new System.EventHandler(this.btnLIBRARIAN_LogOut_Click);
            // 
            // btnLIBRARIAN_Exit
            // 
            this.btnLIBRARIAN_Exit.AnimationHoverSpeed = 0.07F;
            this.btnLIBRARIAN_Exit.AnimationSpeed = 0.03F;
            this.btnLIBRARIAN_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btnLIBRARIAN_Exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.btnLIBRARIAN_Exit.BorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLIBRARIAN_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLIBRARIAN_Exit.FocusedColor = System.Drawing.Color.Empty;
            this.btnLIBRARIAN_Exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLIBRARIAN_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btnLIBRARIAN_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btnLIBRARIAN_Exit.Image")));
            this.btnLIBRARIAN_Exit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLIBRARIAN_Exit.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLIBRARIAN_Exit.Location = new System.Drawing.Point(1232, 0);
            this.btnLIBRARIAN_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btnLIBRARIAN_Exit.Name = "btnLIBRARIAN_Exit";
            this.btnLIBRARIAN_Exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLIBRARIAN_Exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Exit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLIBRARIAN_Exit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLIBRARIAN_Exit.OnHoverImage")));
            this.btnLIBRARIAN_Exit.OnPressedColor = System.Drawing.Color.Black;
            this.btnLIBRARIAN_Exit.Radius = 3;
            this.btnLIBRARIAN_Exit.Size = new System.Drawing.Size(107, 59);
            this.btnLIBRARIAN_Exit.TabIndex = 5;
            this.btnLIBRARIAN_Exit.Text = "Exit";
            this.btnLIBRARIAN_Exit.Click += new System.EventHandler(this.btnLIBRARIAN_Exit_Click);
            // 
            // lblLIBRARIAN_Manager
            // 
            this.lblLIBRARIAN_Manager.AutoSize = true;
            this.lblLIBRARIAN_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblLIBRARIAN_Manager.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblLIBRARIAN_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblLIBRARIAN_Manager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLIBRARIAN_Manager.Location = new System.Drawing.Point(89, 53);
            this.lblLIBRARIAN_Manager.Name = "lblLIBRARIAN_Manager";
            this.lblLIBRARIAN_Manager.Size = new System.Drawing.Size(87, 25);
            this.lblLIBRARIAN_Manager.TabIndex = 0;
            this.lblLIBRARIAN_Manager.Text = "Librarian";
            this.lblLIBRARIAN_Manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLIBRARIAN_UserName
            // 
            this.lblLIBRARIAN_UserName.AutoSize = true;
            this.lblLIBRARIAN_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblLIBRARIAN_UserName.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.lblLIBRARIAN_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblLIBRARIAN_UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLIBRARIAN_UserName.Location = new System.Drawing.Point(89, 3);
            this.lblLIBRARIAN_UserName.Name = "lblLIBRARIAN_UserName";
            this.lblLIBRARIAN_UserName.Size = new System.Drawing.Size(147, 38);
            this.lblLIBRARIAN_UserName.TabIndex = 0;
            this.lblLIBRARIAN_UserName.Text = "UserName";
            this.lblLIBRARIAN_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLIBRARIAN_Avatar
            // 
            this.pbLIBRARIAN_Avatar.BaseColor = System.Drawing.Color.White;
            this.pbLIBRARIAN_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pbLIBRARIAN_Avatar.Image")));
            this.pbLIBRARIAN_Avatar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLIBRARIAN_Avatar.Location = new System.Drawing.Point(3, 3);
            this.pbLIBRARIAN_Avatar.Name = "pbLIBRARIAN_Avatar";
            this.pbLIBRARIAN_Avatar.Size = new System.Drawing.Size(80, 80);
            this.pbLIBRARIAN_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLIBRARIAN_Avatar.TabIndex = 0;
            this.pbLIBRARIAN_Avatar.TabStop = false;
            // 
            // pbLIBRARIAN_Logo
            // 
            this.pbLIBRARIAN_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.pbLIBRARIAN_Logo.BaseColor = System.Drawing.Color.White;
            this.pbLIBRARIAN_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pbLIBRARIAN_Logo.Image")));
            this.pbLIBRARIAN_Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLIBRARIAN_Logo.Location = new System.Drawing.Point(-1, 0);
            this.pbLIBRARIAN_Logo.Name = "pbLIBRARIAN_Logo";
            this.pbLIBRARIAN_Logo.Size = new System.Drawing.Size(160, 100);
            this.pbLIBRARIAN_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLIBRARIAN_Logo.TabIndex = 24;
            this.pbLIBRARIAN_Logo.TabStop = false;
            // 
            // panelLIBRARIAN_Header
            // 
            this.panelLIBRARIAN_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelLIBRARIAN_Header.Controls.Add(this.panelLIBRARIAN_Watch);
            this.panelLIBRARIAN_Header.Controls.Add(this.btnLIBRARIAN_Exit);
            this.panelLIBRARIAN_Header.Controls.Add(this.lblLIBRARIAN_Manager);
            this.panelLIBRARIAN_Header.Controls.Add(this.lblLIBRARIAN_UserName);
            this.panelLIBRARIAN_Header.Controls.Add(this.pbLIBRARIAN_Avatar);
            this.panelLIBRARIAN_Header.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLIBRARIAN_Header.Location = new System.Drawing.Point(159, 0);
            this.panelLIBRARIAN_Header.Name = "panelLIBRARIAN_Header";
            this.panelLIBRARIAN_Header.Size = new System.Drawing.Size(1343, 100);
            this.panelLIBRARIAN_Header.TabIndex = 0;
            // 
            // frmLIBRARIAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panelLIBRARIAN_Menu);
            this.Controls.Add(this.pbLIBRARIAN_Logo);
            this.Controls.Add(this.panelLIBRARIAN_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmLIBRARIAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARIAN";
            this.Load += new System.EventHandler(this.frmLIBRARIAN_Load);
            this.panelLIBRARIAN_Watch.ResumeLayout(false);
            this.panelLIBRARIAN_Watch.PerformLayout();
            this.panelLIBRARIAN_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLIBRARIAN_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLIBRARIAN_Logo)).EndInit();
            this.panelLIBRARIAN_Header.ResumeLayout(false);
            this.panelLIBRARIAN_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Watch;
        private Guna.UI.WinForms.GunaPanel panelLIBRARIAN_Watch;
        private System.Windows.Forms.Label lblWatch_Day;
        private System.Windows.Forms.Label lblWatch_Date;
        private System.Windows.Forms.Label lblWatch_Second;
        private System.Windows.Forms.Label lblWatch_Time;
        private Guna.UI.WinForms.GunaPanel panelLIBRARIAN_Menu;
        private Guna.UI.WinForms.GunaGradientButton btnLIBRARIAN_Borrow;
        private Guna.UI.WinForms.GunaGradientButton btnLIBRARIAN_Book;
        private Guna.UI.WinForms.GunaGradientButton btnLIBRARIAN_Reader;
        private Guna.UI.WinForms.GunaGradientButton btnLIBRARIAN_LogOut;
        private Guna.UI.WinForms.GunaButton btnLIBRARIAN_Exit;
        private Guna.UI.WinForms.GunaLabel lblLIBRARIAN_Manager;
        private Guna.UI.WinForms.GunaLabel lblLIBRARIAN_UserName;
        private Guna.UI.WinForms.GunaPictureBox pbLIBRARIAN_Avatar;
        private Guna.UI.WinForms.GunaPictureBox pbLIBRARIAN_Logo;
        private Guna.UI.WinForms.GunaPanel panelLIBRARIAN_Header;
    }
}