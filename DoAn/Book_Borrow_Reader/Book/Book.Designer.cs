namespace DoAn.MANAGER.Book
{
    partial class frmBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.btnBook_Add = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBook_Remove = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBook_Update = new Guna.UI.WinForms.GunaGradientButton();
            this.dtgBook = new Guna.UI.WinForms.GunaDataGridView();
            this.btnBook_Search = new Guna.UI.WinForms.GunaGradientButton();
            this.txtBook_Search = new Guna.UI.WinForms.GunaTextBox();
            this.lblBook_BookManagement = new Guna.UI.WinForms.GunaLabel();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook_Add
            // 
            this.btnBook_Add.AnimationHoverSpeed = 0.07F;
            this.btnBook_Add.AnimationSpeed = 0.03F;
            this.btnBook_Add.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_Add.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_Add.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_Add.BorderColor = System.Drawing.Color.Black;
            this.btnBook_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_Add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBook_Add.ForeColor = System.Drawing.Color.White;
            this.btnBook_Add.Image = null;
            this.btnBook_Add.ImageSize = new System.Drawing.Size(50, 40);
            this.btnBook_Add.Location = new System.Drawing.Point(1182, 651);
            this.btnBook_Add.Name = "btnBook_Add";
            this.btnBook_Add.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_Add.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_Add.OnHoverImage = null;
            this.btnBook_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_Add.Radius = 2;
            this.btnBook_Add.Size = new System.Drawing.Size(150, 35);
            this.btnBook_Add.TabIndex = 3;
            this.btnBook_Add.Text = "New Book";
            this.btnBook_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_Add.Click += new System.EventHandler(this.btnBook_Add_Click);
            // 
            // btnBook_Remove
            // 
            this.btnBook_Remove.AnimationHoverSpeed = 0.07F;
            this.btnBook_Remove.AnimationSpeed = 0.03F;
            this.btnBook_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_Remove.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_Remove.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_Remove.BorderColor = System.Drawing.Color.Black;
            this.btnBook_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook_Remove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_Remove.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_Remove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBook_Remove.ForeColor = System.Drawing.Color.White;
            this.btnBook_Remove.Image = null;
            this.btnBook_Remove.ImageSize = new System.Drawing.Size(50, 40);
            this.btnBook_Remove.Location = new System.Drawing.Point(870, 652);
            this.btnBook_Remove.Name = "btnBook_Remove";
            this.btnBook_Remove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_Remove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_Remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_Remove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_Remove.OnHoverImage = null;
            this.btnBook_Remove.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_Remove.Radius = 2;
            this.btnBook_Remove.Size = new System.Drawing.Size(150, 35);
            this.btnBook_Remove.TabIndex = 5;
            this.btnBook_Remove.Text = "Remove";
            this.btnBook_Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_Remove.Click += new System.EventHandler(this.btnBook_Remove_Click);
            // 
            // btnBook_Update
            // 
            this.btnBook_Update.AnimationHoverSpeed = 0.07F;
            this.btnBook_Update.AnimationSpeed = 0.03F;
            this.btnBook_Update.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_Update.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_Update.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_Update.BorderColor = System.Drawing.Color.Black;
            this.btnBook_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook_Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_Update.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_Update.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBook_Update.ForeColor = System.Drawing.Color.White;
            this.btnBook_Update.Image = null;
            this.btnBook_Update.ImageSize = new System.Drawing.Size(50, 40);
            this.btnBook_Update.Location = new System.Drawing.Point(1026, 652);
            this.btnBook_Update.Name = "btnBook_Update";
            this.btnBook_Update.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_Update.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_Update.OnHoverImage = null;
            this.btnBook_Update.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_Update.Radius = 2;
            this.btnBook_Update.Size = new System.Drawing.Size(150, 35);
            this.btnBook_Update.TabIndex = 4;
            this.btnBook_Update.Text = "Update";
            this.btnBook_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_Update.Click += new System.EventHandler(this.btnBook_Update_Click);
            // 
            // dtgBook
            // 
            this.dtgBook.AllowUserToResizeColumns = false;
            this.dtgBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBook.BackgroundColor = System.Drawing.Color.White;
            this.dtgBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBook.ColumnHeadersHeight = 50;
            this.dtgBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.SoLuong,
            this.TenSach,
            this.MaDauSach,
            this.TenTacGia,
            this.TenNhaXuatBan,
            this.NamXuatBan,
            this.DonGia});
            this.dtgBook.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBook.EnableHeadersVisualStyles = false;
            this.dtgBook.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgBook.Location = new System.Drawing.Point(4, 83);
            this.dtgBook.MultiSelect = false;
            this.dtgBook.Name = "dtgBook";
            this.dtgBook.ReadOnly = true;
            this.dtgBook.RowHeadersVisible = false;
            this.dtgBook.RowHeadersWidth = 51;
            this.dtgBook.RowTemplate.Height = 24;
            this.dtgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBook.Size = new System.Drawing.Size(1320, 562);
            this.dtgBook.TabIndex = 58;
            this.dtgBook.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgBook.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgBook.ThemeStyle.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkBlue;
            this.dtgBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgBook.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgBook.ThemeStyle.ReadOnly = true;
            this.dtgBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgBook.ThemeStyle.RowsStyle.Height = 24;
            this.dtgBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBook_CellClick);
            // 
            // btnBook_Search
            // 
            this.btnBook_Search.AnimationHoverSpeed = 0.07F;
            this.btnBook_Search.AnimationSpeed = 0.03F;
            this.btnBook_Search.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_Search.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_Search.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_Search.BorderColor = System.Drawing.Color.Black;
            this.btnBook_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_Search.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBook_Search.ForeColor = System.Drawing.Color.Black;
            this.btnBook_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnBook_Search.Image")));
            this.btnBook_Search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_Search.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBook_Search.Location = new System.Drawing.Point(1134, 27);
            this.btnBook_Search.Name = "btnBook_Search";
            this.btnBook_Search.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_Search.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_Search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_Search.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_Search.OnHoverImage = null;
            this.btnBook_Search.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_Search.Size = new System.Drawing.Size(64, 40);
            this.btnBook_Search.TabIndex = 2;
            this.btnBook_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_Search.Click += new System.EventHandler(this.btnBook_Search_Click);
            // 
            // txtBook_Search
            // 
            this.txtBook_Search.BackColor = System.Drawing.Color.Transparent;
            this.txtBook_Search.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBook_Search.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtBook_Search.BorderSize = 1;
            this.txtBook_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBook_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBook_Search.FocusedBorderColor = System.Drawing.Color.RoyalBlue;
            this.txtBook_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBook_Search.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBook_Search.Location = new System.Drawing.Point(861, 26);
            this.txtBook_Search.Name = "txtBook_Search";
            this.txtBook_Search.PasswordChar = '\0';
            this.txtBook_Search.Radius = 2;
            this.txtBook_Search.SelectedText = "";
            this.txtBook_Search.Size = new System.Drawing.Size(334, 40);
            this.txtBook_Search.TabIndex = 1;
            // 
            // lblBook_BookManagement
            // 
            this.lblBook_BookManagement.AutoSize = true;
            this.lblBook_BookManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.lblBook_BookManagement.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_BookManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.lblBook_BookManagement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBook_BookManagement.Location = new System.Drawing.Point(347, 5);
            this.lblBook_BookManagement.Name = "lblBook_BookManagement";
            this.lblBook_BookManagement.Size = new System.Drawing.Size(385, 59);
            this.lblBook_BookManagement.TabIndex = 63;
            this.lblBook_BookManagement.Text = "Book Management";
            this.lblBook_BookManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Book ID";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Number Of Books";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Title of Book";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Title ID";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Author";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // TenNhaXuatBan
            // 
            this.TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.TenNhaXuatBan.HeaderText = "Publisher";
            this.TenNhaXuatBan.MinimumWidth = 6;
            this.TenNhaXuatBan.Name = "TenNhaXuatBan";
            this.TenNhaXuatBan.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Released Date";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Prices";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1336, 695);
            this.Controls.Add(this.lblBook_BookManagement);
            this.Controls.Add(this.btnBook_Remove);
            this.Controls.Add(this.btnBook_Update);
            this.Controls.Add(this.btnBook_Add);
            this.Controls.Add(this.dtgBook);
            this.Controls.Add(this.btnBook_Search);
            this.Controls.Add(this.txtBook_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(118, 80);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnBook_Add;
        private Guna.UI.WinForms.GunaGradientButton btnBook_Remove;
        private Guna.UI.WinForms.GunaGradientButton btnBook_Update;
        private Guna.UI.WinForms.GunaDataGridView dtgBook;
        private Guna.UI.WinForms.GunaGradientButton btnBook_Search;
        private Guna.UI.WinForms.GunaTextBox txtBook_Search;
        private Guna.UI.WinForms.GunaLabel lblBook_BookManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}