namespace DoAn
{
    partial class frmMANAGER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMANAGER));
            this.panelMANAGER_Header = new Guna.UI.WinForms.GunaPanel();
            this.panelMANAGER_Watch = new Guna.UI.WinForms.GunaPanel();
            this.lblWatch_Day = new System.Windows.Forms.Label();
            this.lblWatch_Date = new System.Windows.Forms.Label();
            this.lblWatch_Second = new System.Windows.Forms.Label();
            this.lblWatch_Time = new System.Windows.Forms.Label();
            this.btnMANAGER_Exit = new Guna.UI.WinForms.GunaButton();
            this.lblMANAGER_Manager = new Guna.UI.WinForms.GunaLabel();
            this.lblMANAGER_UserName = new Guna.UI.WinForms.GunaLabel();
            this.pbMANAGER_Avatar = new Guna.UI.WinForms.GunaPictureBox();
            this.pbMANAGER_Logo = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMANAGER_LogOut = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMANAGER_Reader = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMANAGER_Book = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMANAGER_Librarian = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMANAGER_Statistical = new Guna.UI.WinForms.GunaGradientButton();
            this.panelMANAGER_Menu = new Guna.UI.WinForms.GunaPanel();
            this.btnMANAGER_Borrow = new Guna.UI.WinForms.GunaGradientButton();
            this.timer_Watch = new System.Windows.Forms.Timer(this.components);
            this.panelMANAGER_Header.SuspendLayout();
            this.panelMANAGER_Watch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMANAGER_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMANAGER_Logo)).BeginInit();
            this.panelMANAGER_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMANAGER_Header
            // 
            this.panelMANAGER_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelMANAGER_Header.Controls.Add(this.panelMANAGER_Watch);
            this.panelMANAGER_Header.Controls.Add(this.btnMANAGER_Exit);
            this.panelMANAGER_Header.Controls.Add(this.lblMANAGER_Manager);
            this.panelMANAGER_Header.Controls.Add(this.lblMANAGER_UserName);
            this.panelMANAGER_Header.Controls.Add(this.pbMANAGER_Avatar);
            this.panelMANAGER_Header.ForeColor = System.Drawing.SystemColors.Control;
            this.panelMANAGER_Header.Location = new System.Drawing.Point(160, 0);
            this.panelMANAGER_Header.Name = "panelMANAGER_Header";
            this.panelMANAGER_Header.Size = new System.Drawing.Size(1343, 100);
            this.panelMANAGER_Header.TabIndex = 0;
            // 
            // panelMANAGER_Watch
            // 
            this.panelMANAGER_Watch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelMANAGER_Watch.Controls.Add(this.lblWatch_Day);
            this.panelMANAGER_Watch.Controls.Add(this.lblWatch_Date);
            this.panelMANAGER_Watch.Controls.Add(this.lblWatch_Second);
            this.panelMANAGER_Watch.Controls.Add(this.lblWatch_Time);
            this.panelMANAGER_Watch.Location = new System.Drawing.Point(768, 0);
            this.panelMANAGER_Watch.Name = "panelMANAGER_Watch";
            this.panelMANAGER_Watch.Size = new System.Drawing.Size(400, 100);
            this.panelMANAGER_Watch.TabIndex = 0;
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
            // btnMANAGER_Exit
            // 
            this.btnMANAGER_Exit.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Exit.AnimationSpeed = 0.03F;
            this.btnMANAGER_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.btnMANAGER_Exit.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Exit.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.btnMANAGER_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btnMANAGER_Exit.Image")));
            this.btnMANAGER_Exit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMANAGER_Exit.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMANAGER_Exit.Location = new System.Drawing.Point(1232, 0);
            this.btnMANAGER_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btnMANAGER_Exit.Name = "btnMANAGER_Exit";
            this.btnMANAGER_Exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Exit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Exit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnMANAGER_Exit.OnHoverImage")));
            this.btnMANAGER_Exit.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Exit.Radius = 3;
            this.btnMANAGER_Exit.Size = new System.Drawing.Size(107, 59);
            this.btnMANAGER_Exit.TabIndex = 7;
            this.btnMANAGER_Exit.Text = "Exit";
            this.btnMANAGER_Exit.Click += new System.EventHandler(this.btnMANAGER_Exit_Click);
            // 
            // lblMANAGER_Manager
            // 
            this.lblMANAGER_Manager.AutoSize = true;
            this.lblMANAGER_Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblMANAGER_Manager.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblMANAGER_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblMANAGER_Manager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMANAGER_Manager.Location = new System.Drawing.Point(89, 53);
            this.lblMANAGER_Manager.Name = "lblMANAGER_Manager";
            this.lblMANAGER_Manager.Size = new System.Drawing.Size(88, 25);
            this.lblMANAGER_Manager.TabIndex = 0;
            this.lblMANAGER_Manager.Text = "Manager";
            this.lblMANAGER_Manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMANAGER_UserName
            // 
            this.lblMANAGER_UserName.AutoSize = true;
            this.lblMANAGER_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblMANAGER_UserName.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.lblMANAGER_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblMANAGER_UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMANAGER_UserName.Location = new System.Drawing.Point(89, 3);
            this.lblMANAGER_UserName.Name = "lblMANAGER_UserName";
            this.lblMANAGER_UserName.Size = new System.Drawing.Size(147, 38);
            this.lblMANAGER_UserName.TabIndex = 0;
            this.lblMANAGER_UserName.Text = "UserName";
            this.lblMANAGER_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMANAGER_Avatar
            // 
            this.pbMANAGER_Avatar.BaseColor = System.Drawing.Color.White;
            this.pbMANAGER_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pbMANAGER_Avatar.Image")));
            this.pbMANAGER_Avatar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbMANAGER_Avatar.Location = new System.Drawing.Point(3, 3);
            this.pbMANAGER_Avatar.Name = "pbMANAGER_Avatar";
            this.pbMANAGER_Avatar.Size = new System.Drawing.Size(80, 80);
            this.pbMANAGER_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMANAGER_Avatar.TabIndex = 0;
            this.pbMANAGER_Avatar.TabStop = false;
            // 
            // pbMANAGER_Logo
            // 
            this.pbMANAGER_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.pbMANAGER_Logo.BaseColor = System.Drawing.Color.White;
            this.pbMANAGER_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pbMANAGER_Logo.Image")));
            this.pbMANAGER_Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbMANAGER_Logo.Location = new System.Drawing.Point(0, 0);
            this.pbMANAGER_Logo.Name = "pbMANAGER_Logo";
            this.pbMANAGER_Logo.Size = new System.Drawing.Size(160, 100);
            this.pbMANAGER_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMANAGER_Logo.TabIndex = 2;
            this.pbMANAGER_Logo.TabStop = false;
            // 
            // btnMANAGER_LogOut
            // 
            this.btnMANAGER_LogOut.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_LogOut.AnimationSpeed = 0.03F;
            this.btnMANAGER_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_LogOut.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_LogOut.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_LogOut.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_LogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_LogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_LogOut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_LogOut.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnMANAGER_LogOut.Image")));
            this.btnMANAGER_LogOut.ImageSize = new System.Drawing.Size(28, 28);
            this.btnMANAGER_LogOut.Location = new System.Drawing.Point(5, 640);
            this.btnMANAGER_LogOut.Name = "btnMANAGER_LogOut";
            this.btnMANAGER_LogOut.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_LogOut.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_LogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_LogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_LogOut.OnHoverImage = null;
            this.btnMANAGER_LogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_LogOut.Radius = 2;
            this.btnMANAGER_LogOut.Size = new System.Drawing.Size(150, 55);
            this.btnMANAGER_LogOut.TabIndex = 6;
            this.btnMANAGER_LogOut.Text = "Logout";
            this.btnMANAGER_LogOut.Click += new System.EventHandler(this.btnMANAGER_LogOut_Click);
            // 
            // btnMANAGER_Reader
            // 
            this.btnMANAGER_Reader.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Reader.AnimationSpeed = 0.03F;
            this.btnMANAGER_Reader.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Reader.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_Reader.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_Reader.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Reader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Reader.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Reader.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Reader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Reader.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Reader.Image = null;
            this.btnMANAGER_Reader.ImageSize = new System.Drawing.Size(50, 40);
            this.btnMANAGER_Reader.Location = new System.Drawing.Point(5, 200);
            this.btnMANAGER_Reader.Name = "btnMANAGER_Reader";
            this.btnMANAGER_Reader.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_Reader.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Reader.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Reader.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Reader.OnHoverImage = null;
            this.btnMANAGER_Reader.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Reader.Radius = 2;
            this.btnMANAGER_Reader.Size = new System.Drawing.Size(150, 95);
            this.btnMANAGER_Reader.TabIndex = 3;
            this.btnMANAGER_Reader.Text = "Reader";
            this.btnMANAGER_Reader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMANAGER_Reader.Click += new System.EventHandler(this.btnMANAGER_Reader_Click);
            // 
            // btnMANAGER_Book
            // 
            this.btnMANAGER_Book.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Book.AnimationSpeed = 0.03F;
            this.btnMANAGER_Book.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Book.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_Book.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_Book.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Book.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Book.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Book.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Book.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Book.Image = null;
            this.btnMANAGER_Book.ImageSize = new System.Drawing.Size(50, 40);
            this.btnMANAGER_Book.Location = new System.Drawing.Point(5, 100);
            this.btnMANAGER_Book.Name = "btnMANAGER_Book";
            this.btnMANAGER_Book.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_Book.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Book.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Book.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Book.OnHoverImage = null;
            this.btnMANAGER_Book.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Book.Radius = 2;
            this.btnMANAGER_Book.Size = new System.Drawing.Size(150, 95);
            this.btnMANAGER_Book.TabIndex = 2;
            this.btnMANAGER_Book.Text = "Book";
            this.btnMANAGER_Book.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMANAGER_Book.Click += new System.EventHandler(this.btnMANAGER_Book_Click);
            // 
            // btnMANAGER_Librarian
            // 
            this.btnMANAGER_Librarian.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Librarian.AnimationSpeed = 0.03F;
            this.btnMANAGER_Librarian.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Librarian.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_Librarian.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_Librarian.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Librarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Librarian.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Librarian.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Librarian.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Librarian.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Librarian.Image = null;
            this.btnMANAGER_Librarian.ImageSize = new System.Drawing.Size(50, 40);
            this.btnMANAGER_Librarian.Location = new System.Drawing.Point(5, 0);
            this.btnMANAGER_Librarian.Name = "btnMANAGER_Librarian";
            this.btnMANAGER_Librarian.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_Librarian.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Librarian.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Librarian.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Librarian.OnHoverImage = null;
            this.btnMANAGER_Librarian.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Librarian.Radius = 2;
            this.btnMANAGER_Librarian.Size = new System.Drawing.Size(150, 95);
            this.btnMANAGER_Librarian.TabIndex = 1;
            this.btnMANAGER_Librarian.Text = "Librarian";
            this.btnMANAGER_Librarian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMANAGER_Librarian.Click += new System.EventHandler(this.btnMANAGER_Librarian_Click);
            // 
            // btnMANAGER_Statistical
            // 
            this.btnMANAGER_Statistical.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Statistical.AnimationSpeed = 0.03F;
            this.btnMANAGER_Statistical.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Statistical.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_Statistical.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_Statistical.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Statistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Statistical.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Statistical.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Statistical.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Statistical.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Statistical.Image = null;
            this.btnMANAGER_Statistical.ImageSize = new System.Drawing.Size(50, 40);
            this.btnMANAGER_Statistical.Location = new System.Drawing.Point(5, 400);
            this.btnMANAGER_Statistical.Name = "btnMANAGER_Statistical";
            this.btnMANAGER_Statistical.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_Statistical.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Statistical.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Statistical.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Statistical.OnHoverImage = null;
            this.btnMANAGER_Statistical.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Statistical.Radius = 2;
            this.btnMANAGER_Statistical.Size = new System.Drawing.Size(150, 95);
            this.btnMANAGER_Statistical.TabIndex = 5;
            this.btnMANAGER_Statistical.Text = "Report";
            this.btnMANAGER_Statistical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMANAGER_Statistical.Click += new System.EventHandler(this.btnMANAGER_Statistical_Click);
            // 
            // panelMANAGER_Menu
            // 
            this.panelMANAGER_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_Borrow);
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_Statistical);
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_Librarian);
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_Book);
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_Reader);
            this.panelMANAGER_Menu.Controls.Add(this.btnMANAGER_LogOut);
            this.panelMANAGER_Menu.Location = new System.Drawing.Point(0, 100);
            this.panelMANAGER_Menu.Name = "panelMANAGER_Menu";
            this.panelMANAGER_Menu.Size = new System.Drawing.Size(160, 700);
            this.panelMANAGER_Menu.TabIndex = 0;
            // 
            // btnMANAGER_Borrow
            // 
            this.btnMANAGER_Borrow.AnimationHoverSpeed = 0.07F;
            this.btnMANAGER_Borrow.AnimationSpeed = 0.03F;
            this.btnMANAGER_Borrow.BackColor = System.Drawing.Color.Transparent;
            this.btnMANAGER_Borrow.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnMANAGER_Borrow.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnMANAGER_Borrow.BorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMANAGER_Borrow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMANAGER_Borrow.FocusedColor = System.Drawing.Color.Empty;
            this.btnMANAGER_Borrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMANAGER_Borrow.ForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Borrow.Image = null;
            this.btnMANAGER_Borrow.ImageSize = new System.Drawing.Size(50, 40);
            this.btnMANAGER_Borrow.Location = new System.Drawing.Point(5, 300);
            this.btnMANAGER_Borrow.Name = "btnMANAGER_Borrow";
            this.btnMANAGER_Borrow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnMANAGER_Borrow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnMANAGER_Borrow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMANAGER_Borrow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMANAGER_Borrow.OnHoverImage = null;
            this.btnMANAGER_Borrow.OnPressedColor = System.Drawing.Color.Black;
            this.btnMANAGER_Borrow.Radius = 2;
            this.btnMANAGER_Borrow.Size = new System.Drawing.Size(150, 95);
            this.btnMANAGER_Borrow.TabIndex = 4;
            this.btnMANAGER_Borrow.Text = "Borrow";
            this.btnMANAGER_Borrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMANAGER_Borrow.Click += new System.EventHandler(this.btnMANAGER_Borrow_Click);
            // 
            // timer_Watch
            // 
            this.timer_Watch.Interval = 1000;
            this.timer_Watch.Tick += new System.EventHandler(this.timer_Watch_Tick);
            // 
            // frmMANAGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.pbMANAGER_Logo);
            this.Controls.Add(this.panelMANAGER_Header);
            this.Controls.Add(this.panelMANAGER_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMANAGER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMANAGER_Load);
            this.panelMANAGER_Header.ResumeLayout(false);
            this.panelMANAGER_Header.PerformLayout();
            this.panelMANAGER_Watch.ResumeLayout(false);
            this.panelMANAGER_Watch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMANAGER_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMANAGER_Logo)).EndInit();
            this.panelMANAGER_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelMANAGER_Header;
        private Guna.UI.WinForms.GunaLabel lblMANAGER_Manager;
        private Guna.UI.WinForms.GunaLabel lblMANAGER_UserName;
        private Guna.UI.WinForms.GunaPictureBox pbMANAGER_Avatar;
        private Guna.UI.WinForms.GunaPictureBox pbMANAGER_Logo;
        private Guna.UI.WinForms.GunaButton btnMANAGER_Exit;
        
        private Guna.UI.WinForms.GunaPanel panelMANAGER_Watch;
        private System.Windows.Forms.Label lblWatch_Time;
        private System.Windows.Forms.Label lblWatch_Second;
        private System.Windows.Forms.Label lblWatch_Date;
        private System.Windows.Forms.Label lblWatch_Day;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_LogOut;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_Reader;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_Book;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_Librarian;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_Statistical;
        private Guna.UI.WinForms.GunaPanel panelMANAGER_Menu;
        private System.Windows.Forms.Timer timer_Watch;
        private Guna.UI.WinForms.GunaGradientButton btnMANAGER_Borrow;
    }
}