namespace DoAn.MANAGER.Borrow.Add_Update_borrow
{
    partial class frmBorrow_Borrow
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
            System.Windows.Forms.ColumnHeader colSL;
            System.Windows.Forms.ColumnHeader colTenSach;
            System.Windows.Forms.ColumnHeader MaSach;
            this.BorrowBook_btnCancel = new Guna.UI.WinForms.GunaGradientButton();
            this.BorrowBook_Right = new Guna.UI.WinForms.GunaGradientButton();
            this.BorrowBook_nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BorrowBook_Left = new Guna.UI.WinForms.GunaGradientButton();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBorrowBook_SachCoTheMuon = new System.Windows.Forms.ListView();
            this.colMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lstBorrowBook_SachMuon = new System.Windows.Forms.ListView();
            this.BorrowBook_btnBorrowBook = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBook_nudSoLuong)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colSL
            // 
            colSL.Text = "Quanlity";
            colSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colSL.Width = 103;
            // 
            // colTenSach
            // 
            colTenSach.Text = "Name Of Book";
            colTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colTenSach.Width = 375;
            // 
            // MaSach
            // 
            MaSach.Text = "Book ID";
            MaSach.Width = 88;
            // 
            // BorrowBook_btnCancel
            // 
            this.BorrowBook_btnCancel.AnimationHoverSpeed = 0.07F;
            this.BorrowBook_btnCancel.AnimationSpeed = 0.03F;
            this.BorrowBook_btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BorrowBook_btnCancel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BorrowBook_btnCancel.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BorrowBook_btnCancel.BorderColor = System.Drawing.Color.Black;
            this.BorrowBook_btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BorrowBook_btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.BorrowBook_btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BorrowBook_btnCancel.ForeColor = System.Drawing.Color.White;
            this.BorrowBook_btnCancel.Image = null;
            this.BorrowBook_btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.BorrowBook_btnCancel.Location = new System.Drawing.Point(574, 627);
            this.BorrowBook_btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrowBook_btnCancel.Name = "BorrowBook_btnCancel";
            this.BorrowBook_btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BorrowBook_btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BorrowBook_btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BorrowBook_btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.BorrowBook_btnCancel.OnHoverImage = null;
            this.BorrowBook_btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.BorrowBook_btnCancel.Radius = 3;
            this.BorrowBook_btnCancel.Size = new System.Drawing.Size(370, 57);
            this.BorrowBook_btnCancel.TabIndex = 4;
            this.BorrowBook_btnCancel.Text = "Cancel";
            this.BorrowBook_btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorrowBook_btnCancel.Click += new System.EventHandler(this.BorrowBook_btnCancel_Click);
            // 
            // BorrowBook_Right
            // 
            this.BorrowBook_Right.AnimationHoverSpeed = 0.07F;
            this.BorrowBook_Right.AnimationSpeed = 0.03F;
            this.BorrowBook_Right.BackColor = System.Drawing.Color.Transparent;
            this.BorrowBook_Right.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BorrowBook_Right.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BorrowBook_Right.BorderColor = System.Drawing.Color.Black;
            this.BorrowBook_Right.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BorrowBook_Right.FocusedColor = System.Drawing.Color.Empty;
            this.BorrowBook_Right.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBook_Right.ForeColor = System.Drawing.Color.White;
            this.BorrowBook_Right.Image = null;
            this.BorrowBook_Right.ImageSize = new System.Drawing.Size(20, 20);
            this.BorrowBook_Right.Location = new System.Drawing.Point(613, 414);
            this.BorrowBook_Right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrowBook_Right.Name = "BorrowBook_Right";
            this.BorrowBook_Right.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.BorrowBook_Right.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BorrowBook_Right.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BorrowBook_Right.OnHoverForeColor = System.Drawing.Color.White;
            this.BorrowBook_Right.OnHoverImage = null;
            this.BorrowBook_Right.OnPressedColor = System.Drawing.Color.Black;
            this.BorrowBook_Right.Radius = 3;
            this.BorrowBook_Right.Size = new System.Drawing.Size(113, 48);
            this.BorrowBook_Right.TabIndex = 1;
            this.BorrowBook_Right.Text = ">";
            this.BorrowBook_Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorrowBook_Right.Click += new System.EventHandler(this.BorrowBook_Right_Click);
            // 
            // BorrowBook_nudSoLuong
            // 
            this.BorrowBook_nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BorrowBook_nudSoLuong.Location = new System.Drawing.Point(613, 296);
            this.BorrowBook_nudSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowBook_nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BorrowBook_nudSoLuong.Name = "BorrowBook_nudSoLuong";
            this.BorrowBook_nudSoLuong.Size = new System.Drawing.Size(113, 30);
            this.BorrowBook_nudSoLuong.TabIndex = 73;
            this.BorrowBook_nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(624, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Quanlity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(954, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 74;
            this.label5.Text = "Book Borrow";
            // 
            // BorrowBook_Left
            // 
            this.BorrowBook_Left.AnimationHoverSpeed = 0.07F;
            this.BorrowBook_Left.AnimationSpeed = 0.03F;
            this.BorrowBook_Left.BackColor = System.Drawing.Color.Transparent;
            this.BorrowBook_Left.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BorrowBook_Left.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BorrowBook_Left.BorderColor = System.Drawing.Color.Black;
            this.BorrowBook_Left.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BorrowBook_Left.FocusedColor = System.Drawing.Color.Empty;
            this.BorrowBook_Left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBook_Left.ForeColor = System.Drawing.Color.White;
            this.BorrowBook_Left.Image = null;
            this.BorrowBook_Left.ImageSize = new System.Drawing.Size(20, 20);
            this.BorrowBook_Left.Location = new System.Drawing.Point(613, 486);
            this.BorrowBook_Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrowBook_Left.Name = "BorrowBook_Left";
            this.BorrowBook_Left.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.BorrowBook_Left.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BorrowBook_Left.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BorrowBook_Left.OnHoverForeColor = System.Drawing.Color.White;
            this.BorrowBook_Left.OnHoverImage = null;
            this.BorrowBook_Left.OnPressedColor = System.Drawing.Color.Black;
            this.BorrowBook_Left.Radius = 3;
            this.BorrowBook_Left.Size = new System.Drawing.Size(113, 48);
            this.BorrowBook_Left.TabIndex = 2;
            this.BorrowBook_Left.Text = "<";
            this.BorrowBook_Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorrowBook_Left.Click += new System.EventHandler(this.BorrowBook_Left_Click);
            // 
            // colTen
            // 
            this.colTen.Text = "Name Of Book";
            this.colTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTen.Width = 330;
            // 
            // lstBorrowBook_SachCoTheMuon
            // 
            this.lstBorrowBook_SachCoTheMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMa,
            this.colTen});
            this.lstBorrowBook_SachCoTheMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstBorrowBook_SachCoTheMuon.FullRowSelect = true;
            this.lstBorrowBook_SachCoTheMuon.HideSelection = false;
            this.lstBorrowBook_SachCoTheMuon.Location = new System.Drawing.Point(13, 203);
            this.lstBorrowBook_SachCoTheMuon.Margin = new System.Windows.Forms.Padding(4);
            this.lstBorrowBook_SachCoTheMuon.MultiSelect = false;
            this.lstBorrowBook_SachCoTheMuon.Name = "lstBorrowBook_SachCoTheMuon";
            this.lstBorrowBook_SachCoTheMuon.Size = new System.Drawing.Size(580, 395);
            this.lstBorrowBook_SachCoTheMuon.TabIndex = 70;
            this.lstBorrowBook_SachCoTheMuon.UseCompatibleStateImageBehavior = false;
            this.lstBorrowBook_SachCoTheMuon.View = System.Windows.Forms.View.Details;
            // 
            // colMa
            // 
            this.colMa.Text = "Book ID";
            this.colMa.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(178, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 71;
            this.label4.Text = "Book Available";
            // 
            // lstBorrowBook_SachMuon
            // 
            this.lstBorrowBook_SachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            MaSach,
            colTenSach,
            colSL});
            this.lstBorrowBook_SachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstBorrowBook_SachMuon.FullRowSelect = true;
            this.lstBorrowBook_SachMuon.HideSelection = false;
            this.lstBorrowBook_SachMuon.Location = new System.Drawing.Point(743, 203);
            this.lstBorrowBook_SachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.lstBorrowBook_SachMuon.Name = "lstBorrowBook_SachMuon";
            this.lstBorrowBook_SachMuon.Size = new System.Drawing.Size(580, 395);
            this.lstBorrowBook_SachMuon.TabIndex = 69;
            this.lstBorrowBook_SachMuon.UseCompatibleStateImageBehavior = false;
            this.lstBorrowBook_SachMuon.View = System.Windows.Forms.View.Details;
            // 
            // BorrowBook_btnBorrowBook
            // 
            this.BorrowBook_btnBorrowBook.AnimationHoverSpeed = 0.07F;
            this.BorrowBook_btnBorrowBook.AnimationSpeed = 0.03F;
            this.BorrowBook_btnBorrowBook.BackColor = System.Drawing.Color.Transparent;
            this.BorrowBook_btnBorrowBook.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.BorrowBook_btnBorrowBook.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.BorrowBook_btnBorrowBook.BorderColor = System.Drawing.Color.Black;
            this.BorrowBook_btnBorrowBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BorrowBook_btnBorrowBook.FocusedColor = System.Drawing.Color.Empty;
            this.BorrowBook_btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBook_btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.BorrowBook_btnBorrowBook.Image = null;
            this.BorrowBook_btnBorrowBook.ImageSize = new System.Drawing.Size(20, 20);
            this.BorrowBook_btnBorrowBook.Location = new System.Drawing.Point(950, 627);
            this.BorrowBook_btnBorrowBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorrowBook_btnBorrowBook.Name = "BorrowBook_btnBorrowBook";
            this.BorrowBook_btnBorrowBook.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BorrowBook_btnBorrowBook.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BorrowBook_btnBorrowBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BorrowBook_btnBorrowBook.OnHoverForeColor = System.Drawing.Color.White;
            this.BorrowBook_btnBorrowBook.OnHoverImage = null;
            this.BorrowBook_btnBorrowBook.OnPressedColor = System.Drawing.Color.Black;
            this.BorrowBook_btnBorrowBook.Radius = 3;
            this.BorrowBook_btnBorrowBook.Size = new System.Drawing.Size(370, 57);
            this.BorrowBook_btnBorrowBook.TabIndex = 3;
            this.BorrowBook_btnBorrowBook.Text = "Borrow";
            this.BorrowBook_btnBorrowBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BorrowBook_btnBorrowBook.Click += new System.EventHandler(this.BorrowBook_btnBorrowBook_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1336, 126);
            this.gunaPanel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(476, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 76);
            this.label1.TabIndex = 56;
            this.label1.Text = "Borrow Book";
            // 
            // frmBorrow_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1336, 695);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.BorrowBook_btnCancel);
            this.Controls.Add(this.BorrowBook_Right);
            this.Controls.Add(this.BorrowBook_nudSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorrowBook_Left);
            this.Controls.Add(this.lstBorrowBook_SachCoTheMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBorrowBook_SachMuon);
            this.Controls.Add(this.BorrowBook_btnBorrowBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(325, 170);
            this.Name = "frmBorrow_Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmBorrow_Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBook_nudSoLuong)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton BorrowBook_btnCancel;
        private Guna.UI.WinForms.GunaGradientButton BorrowBook_Right;
        private System.Windows.Forms.NumericUpDown BorrowBook_nudSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGradientButton BorrowBook_Left;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ListView lstBorrowBook_SachCoTheMuon;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstBorrowBook_SachMuon;
        private Guna.UI.WinForms.GunaGradientButton BorrowBook_btnBorrowBook;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label1;
    }
}