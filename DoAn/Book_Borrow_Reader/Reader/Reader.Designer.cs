namespace DoAn.MANAGER_Buttons
{
    partial class frmReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReader));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReader_Search = new Guna.UI.WinForms.GunaGradientButton();
            this.txtReader_Search = new Guna.UI.WinForms.GunaTextBox();
            this.lblReader_ReaderManagement = new Guna.UI.WinForms.GunaLabel();
            this.dtgReader = new Guna.UI.WinForms.GunaDataGridView();
            this.btnReader_Add = new Guna.UI.WinForms.GunaGradientButton();
            this.btnReader_Update = new Guna.UI.WinForms.GunaGradientButton();
            this.btnReader_Remove = new Guna.UI.WinForms.GunaGradientButton();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReader_Search
            // 
            this.btnReader_Search.AnimationHoverSpeed = 0.07F;
            this.btnReader_Search.AnimationSpeed = 0.03F;
            this.btnReader_Search.BackColor = System.Drawing.Color.Transparent;
            this.btnReader_Search.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnReader_Search.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnReader_Search.BorderColor = System.Drawing.Color.Black;
            this.btnReader_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReader_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReader_Search.FocusedColor = System.Drawing.Color.Empty;
            this.btnReader_Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReader_Search.ForeColor = System.Drawing.Color.Black;
            this.btnReader_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnReader_Search.Image")));
            this.btnReader_Search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReader_Search.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReader_Search.Location = new System.Drawing.Point(1134, 25);
            this.btnReader_Search.Name = "btnReader_Search";
            this.btnReader_Search.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReader_Search.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReader_Search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReader_Search.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReader_Search.OnHoverImage = null;
            this.btnReader_Search.OnPressedColor = System.Drawing.Color.Black;
            this.btnReader_Search.Size = new System.Drawing.Size(64, 40);
            this.btnReader_Search.TabIndex = 2;
            this.btnReader_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReader_Search.Click += new System.EventHandler(this.btnReader_Search_Click);
            // 
            // txtReader_Search
            // 
            this.txtReader_Search.BackColor = System.Drawing.Color.Transparent;
            this.txtReader_Search.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtReader_Search.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtReader_Search.BorderSize = 1;
            this.txtReader_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReader_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReader_Search.FocusedBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtReader_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReader_Search.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtReader_Search.Location = new System.Drawing.Point(864, 23);
            this.txtReader_Search.Name = "txtReader_Search";
            this.txtReader_Search.PasswordChar = '\0';
            this.txtReader_Search.Radius = 2;
            this.txtReader_Search.SelectedText = "";
            this.txtReader_Search.Size = new System.Drawing.Size(334, 42);
            this.txtReader_Search.TabIndex = 1;
            // 
            // lblReader_ReaderManagement
            // 
            this.lblReader_ReaderManagement.AutoSize = true;
            this.lblReader_ReaderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblReader_ReaderManagement.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReader_ReaderManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblReader_ReaderManagement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReader_ReaderManagement.Location = new System.Drawing.Point(379, 9);
            this.lblReader_ReaderManagement.Name = "lblReader_ReaderManagement";
            this.lblReader_ReaderManagement.Size = new System.Drawing.Size(420, 59);
            this.lblReader_ReaderManagement.TabIndex = 34;
            this.lblReader_ReaderManagement.Text = "Reader Management";
            this.lblReader_ReaderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgReader
            // 
            this.dtgReader.AllowUserToResizeColumns = false;
            this.dtgReader.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgReader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReader.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgReader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReader.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgReader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReader.ColumnHeadersHeight = 50;
            this.dtgReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.CMND,
            this.DiaChi,
            this.SoThe});
            this.dtgReader.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReader.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgReader.EnableHeadersVisualStyles = false;
            this.dtgReader.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgReader.Location = new System.Drawing.Point(12, 106);
            this.dtgReader.MultiSelect = false;
            this.dtgReader.Name = "dtgReader";
            this.dtgReader.ReadOnly = true;
            this.dtgReader.RowHeadersVisible = false;
            this.dtgReader.RowHeadersWidth = 51;
            this.dtgReader.RowTemplate.Height = 24;
            this.dtgReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReader.Size = new System.Drawing.Size(1318, 540);
            this.dtgReader.TabIndex = 0;
            this.dtgReader.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgReader.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgReader.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgReader.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgReader.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgReader.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgReader.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgReader.ThemeStyle.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgReader.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dtgReader.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgReader.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgReader.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgReader.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgReader.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgReader.ThemeStyle.ReadOnly = true;
            this.dtgReader.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgReader.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgReader.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgReader.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgReader.ThemeStyle.RowsStyle.Height = 24;
            this.dtgReader.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgReader.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReader_CellClick);
            // 
            // btnReader_Add
            // 
            this.btnReader_Add.AnimationHoverSpeed = 0.07F;
            this.btnReader_Add.AnimationSpeed = 0.03F;
            this.btnReader_Add.BackColor = System.Drawing.Color.Transparent;
            this.btnReader_Add.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnReader_Add.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnReader_Add.BorderColor = System.Drawing.Color.Black;
            this.btnReader_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReader_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReader_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btnReader_Add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReader_Add.ForeColor = System.Drawing.Color.White;
            this.btnReader_Add.Image = null;
            this.btnReader_Add.ImageSize = new System.Drawing.Size(50, 40);
            this.btnReader_Add.Location = new System.Drawing.Point(1180, 652);
            this.btnReader_Add.Name = "btnReader_Add";
            this.btnReader_Add.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReader_Add.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReader_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReader_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReader_Add.OnHoverImage = null;
            this.btnReader_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btnReader_Add.Radius = 2;
            this.btnReader_Add.Size = new System.Drawing.Size(150, 35);
            this.btnReader_Add.TabIndex = 3;
            this.btnReader_Add.Text = "New Reader";
            this.btnReader_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReader_Add.Click += new System.EventHandler(this.btnReader_Add_Click);
            // 
            // btnReader_Update
            // 
            this.btnReader_Update.AnimationHoverSpeed = 0.07F;
            this.btnReader_Update.AnimationSpeed = 0.03F;
            this.btnReader_Update.BackColor = System.Drawing.Color.Transparent;
            this.btnReader_Update.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnReader_Update.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnReader_Update.BorderColor = System.Drawing.Color.Black;
            this.btnReader_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReader_Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReader_Update.FocusedColor = System.Drawing.Color.Empty;
            this.btnReader_Update.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReader_Update.ForeColor = System.Drawing.Color.White;
            this.btnReader_Update.Image = null;
            this.btnReader_Update.ImageSize = new System.Drawing.Size(50, 40);
            this.btnReader_Update.Location = new System.Drawing.Point(1024, 652);
            this.btnReader_Update.Name = "btnReader_Update";
            this.btnReader_Update.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReader_Update.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReader_Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReader_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReader_Update.OnHoverImage = null;
            this.btnReader_Update.OnPressedColor = System.Drawing.Color.Black;
            this.btnReader_Update.Radius = 2;
            this.btnReader_Update.Size = new System.Drawing.Size(150, 35);
            this.btnReader_Update.TabIndex = 4;
            this.btnReader_Update.Text = "Update";
            this.btnReader_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReader_Update.Click += new System.EventHandler(this.btnReader_Update_Click);
            // 
            // btnReader_Remove
            // 
            this.btnReader_Remove.AnimationHoverSpeed = 0.07F;
            this.btnReader_Remove.AnimationSpeed = 0.03F;
            this.btnReader_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btnReader_Remove.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnReader_Remove.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnReader_Remove.BorderColor = System.Drawing.Color.Black;
            this.btnReader_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReader_Remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReader_Remove.FocusedColor = System.Drawing.Color.Empty;
            this.btnReader_Remove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReader_Remove.ForeColor = System.Drawing.Color.White;
            this.btnReader_Remove.Image = null;
            this.btnReader_Remove.ImageSize = new System.Drawing.Size(50, 40);
            this.btnReader_Remove.Location = new System.Drawing.Point(868, 652);
            this.btnReader_Remove.Name = "btnReader_Remove";
            this.btnReader_Remove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReader_Remove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReader_Remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReader_Remove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReader_Remove.OnHoverImage = null;
            this.btnReader_Remove.OnPressedColor = System.Drawing.Color.Black;
            this.btnReader_Remove.Radius = 2;
            this.btnReader_Remove.Size = new System.Drawing.Size(150, 35);
            this.btnReader_Remove.TabIndex = 5;
            this.btnReader_Remove.Text = "Remove";
            this.btnReader_Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReader_Remove.Click += new System.EventHandler(this.btnReader_Remove_Click);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Reader ID";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Name";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Identity Number";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Address";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoThe
            // 
            this.SoThe.DataPropertyName = "SoThe";
            this.SoThe.HeaderText = "Card Number";
            this.SoThe.MinimumWidth = 6;
            this.SoThe.Name = "SoThe";
            this.SoThe.ReadOnly = true;
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1335, 695);
            this.Controls.Add(this.btnReader_Remove);
            this.Controls.Add(this.btnReader_Update);
            this.Controls.Add(this.btnReader_Add);
            this.Controls.Add(this.dtgReader);
            this.Controls.Add(this.lblReader_ReaderManagement);
            this.Controls.Add(this.btnReader_Search);
            this.Controls.Add(this.txtReader_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(118, 80);
            this.Name = "frmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.frmReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnReader_Search;
        private Guna.UI.WinForms.GunaTextBox txtReader_Search;
        private Guna.UI.WinForms.GunaLabel lblReader_ReaderManagement;
        private Guna.UI.WinForms.GunaDataGridView dtgReader;
        private Guna.UI.WinForms.GunaGradientButton btnReader_Add;
        private Guna.UI.WinForms.GunaGradientButton btnReader_Update;
        private Guna.UI.WinForms.GunaGradientButton btnReader_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThe;
    }
}