namespace DoAn.Book_Borrow_Reader.Borrow.Add_Update_borrow
{
    partial class frmBorow_Bill
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
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpBorrowUpdate_PayDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpBorrowUpdate_BorrowDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblBorrowUpdate_PayDate = new System.Windows.Forms.Label();
            this.lblBorrowUpdate_BorrowDate = new System.Windows.Forms.Label();
            this.BorrowUpdate_MemberCard = new System.Windows.Forms.Label();
            this.txtBorrowUpdate_TagNumber = new Guna.UI.WinForms.GunaTextBox();
            this.lblBorrowUpdate_LibrarianID = new System.Windows.Forms.Label();
            this.BorrowUpdate_BorrowID = new System.Windows.Forms.Label();
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Bill_btnOK = new Guna.UI.WinForms.GunaGradientButton();
            this.txtBorrowUpdate_LibrarianID = new Guna.UI.WinForms.GunaTextBox();
            this.txtBorrowUpdate_ID = new Guna.UI.WinForms.GunaTextBox();
            this.Bill_btnCancel = new Guna.UI.WinForms.GunaGradientButton();
            this.panelBorrowUpdate_Information = new System.Windows.Forms.Panel();
            this.gunaPanel1.SuspendLayout();
            this.panelBorrowUpdate_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Quanlity";
            this.colSoLuong.Width = 200;
            // 
            // dtpBorrowUpdate_PayDate
            // 
            this.dtpBorrowUpdate_PayDate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpBorrowUpdate_PayDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpBorrowUpdate_PayDate.CustomFormat = null;
            this.dtpBorrowUpdate_PayDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBorrowUpdate_PayDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_PayDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBorrowUpdate_PayDate.ForeColor = System.Drawing.Color.Black;
            this.dtpBorrowUpdate_PayDate.Location = new System.Drawing.Point(780, 121);
            this.dtpBorrowUpdate_PayDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBorrowUpdate_PayDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowUpdate_PayDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowUpdate_PayDate.Name = "dtpBorrowUpdate_PayDate";
            this.dtpBorrowUpdate_PayDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpBorrowUpdate_PayDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_PayDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_PayDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpBorrowUpdate_PayDate.Size = new System.Drawing.Size(415, 37);
            this.dtpBorrowUpdate_PayDate.TabIndex = 5;
            this.dtpBorrowUpdate_PayDate.Text = "24/06/2020";
            this.dtpBorrowUpdate_PayDate.Value = new System.DateTime(2020, 6, 24, 9, 56, 15, 737);
            // 
            // dtpBorrowUpdate_BorrowDate
            // 
            this.dtpBorrowUpdate_BorrowDate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpBorrowUpdate_BorrowDate.BorderColor = System.Drawing.Color.Silver;
            this.dtpBorrowUpdate_BorrowDate.CustomFormat = null;
            this.dtpBorrowUpdate_BorrowDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBorrowUpdate_BorrowDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_BorrowDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBorrowUpdate_BorrowDate.ForeColor = System.Drawing.Color.Black;
            this.dtpBorrowUpdate_BorrowDate.Location = new System.Drawing.Point(81, 121);
            this.dtpBorrowUpdate_BorrowDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBorrowUpdate_BorrowDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrowUpdate_BorrowDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrowUpdate_BorrowDate.Name = "dtpBorrowUpdate_BorrowDate";
            this.dtpBorrowUpdate_BorrowDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpBorrowUpdate_BorrowDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_BorrowDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBorrowUpdate_BorrowDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpBorrowUpdate_BorrowDate.Size = new System.Drawing.Size(419, 37);
            this.dtpBorrowUpdate_BorrowDate.TabIndex = 4;
            this.dtpBorrowUpdate_BorrowDate.Text = "24/06/2020";
            this.dtpBorrowUpdate_BorrowDate.Value = new System.DateTime(2020, 6, 24, 9, 56, 15, 737);
            // 
            // lblBorrowUpdate_PayDate
            // 
            this.lblBorrowUpdate_PayDate.AutoSize = true;
            this.lblBorrowUpdate_PayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowUpdate_PayDate.Location = new System.Drawing.Point(955, 161);
            this.lblBorrowUpdate_PayDate.Name = "lblBorrowUpdate_PayDate";
            this.lblBorrowUpdate_PayDate.Size = new System.Drawing.Size(92, 25);
            this.lblBorrowUpdate_PayDate.TabIndex = 63;
            this.lblBorrowUpdate_PayDate.Text = "Pay Date";
            // 
            // lblBorrowUpdate_BorrowDate
            // 
            this.lblBorrowUpdate_BorrowDate.AutoSize = true;
            this.lblBorrowUpdate_BorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowUpdate_BorrowDate.Location = new System.Drawing.Point(219, 160);
            this.lblBorrowUpdate_BorrowDate.Name = "lblBorrowUpdate_BorrowDate";
            this.lblBorrowUpdate_BorrowDate.Size = new System.Drawing.Size(119, 25);
            this.lblBorrowUpdate_BorrowDate.TabIndex = 62;
            this.lblBorrowUpdate_BorrowDate.Text = "Borrow Date";
            // 
            // BorrowUpdate_MemberCard
            // 
            this.BorrowUpdate_MemberCard.AutoSize = true;
            this.BorrowUpdate_MemberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowUpdate_MemberCard.Location = new System.Drawing.Point(576, 79);
            this.BorrowUpdate_MemberCard.Name = "BorrowUpdate_MemberCard";
            this.BorrowUpdate_MemberCard.Size = new System.Drawing.Size(132, 25);
            this.BorrowUpdate_MemberCard.TabIndex = 59;
            this.BorrowUpdate_MemberCard.Text = "Member Card";
            // 
            // txtBorrowUpdate_TagNumber
            // 
            this.txtBorrowUpdate_TagNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowUpdate_TagNumber.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBorrowUpdate_TagNumber.BorderColor = System.Drawing.Color.White;
            this.txtBorrowUpdate_TagNumber.BorderSize = 0;
            this.txtBorrowUpdate_TagNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowUpdate_TagNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBorrowUpdate_TagNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBorrowUpdate_TagNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBorrowUpdate_TagNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowUpdate_TagNumber.Location = new System.Drawing.Point(504, 21);
            this.txtBorrowUpdate_TagNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowUpdate_TagNumber.Name = "txtBorrowUpdate_TagNumber";
            this.txtBorrowUpdate_TagNumber.PasswordChar = '\0';
            this.txtBorrowUpdate_TagNumber.Radius = 3;
            this.txtBorrowUpdate_TagNumber.SelectedText = "";
            this.txtBorrowUpdate_TagNumber.Size = new System.Drawing.Size(273, 46);
            this.txtBorrowUpdate_TagNumber.TabIndex = 2;
            // 
            // lblBorrowUpdate_LibrarianID
            // 
            this.lblBorrowUpdate_LibrarianID.AutoSize = true;
            this.lblBorrowUpdate_LibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowUpdate_LibrarianID.Location = new System.Drawing.Point(1005, 79);
            this.lblBorrowUpdate_LibrarianID.Name = "lblBorrowUpdate_LibrarianID";
            this.lblBorrowUpdate_LibrarianID.Size = new System.Drawing.Size(111, 25);
            this.lblBorrowUpdate_LibrarianID.TabIndex = 56;
            this.lblBorrowUpdate_LibrarianID.Text = "Librarian ID";
            // 
            // BorrowUpdate_BorrowID
            // 
            this.BorrowUpdate_BorrowID.AutoSize = true;
            this.BorrowUpdate_BorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowUpdate_BorrowID.Location = new System.Drawing.Point(173, 79);
            this.BorrowUpdate_BorrowID.Name = "BorrowUpdate_BorrowID";
            this.BorrowUpdate_BorrowID.Size = new System.Drawing.Size(97, 25);
            this.BorrowUpdate_BorrowID.TabIndex = 55;
            this.BorrowUpdate_BorrowID.Text = "Borrow ID";
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Book ID";
            this.colMaSach.Width = 200;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSach,
            this.colTenSach,
            this.colSoLuong});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(8, 313);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(1320, 310);
            this.lsvBill.TabIndex = 74;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Name Of Book";
            this.colTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenSach.Width = 920;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1336, 95);
            this.gunaPanel1.TabIndex = 73;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 27F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.gunaLabel1.Location = new System.Drawing.Point(646, 9);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 61);
            this.gunaLabel1.TabIndex = 54;
            this.gunaLabel1.Text = "Bill";
            // 
            // Bill_btnOK
            // 
            this.Bill_btnOK.AnimationHoverSpeed = 0.07F;
            this.Bill_btnOK.AnimationSpeed = 0.03F;
            this.Bill_btnOK.BackColor = System.Drawing.Color.Transparent;
            this.Bill_btnOK.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.Bill_btnOK.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.Bill_btnOK.BorderColor = System.Drawing.Color.Black;
            this.Bill_btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Bill_btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.Bill_btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_btnOK.ForeColor = System.Drawing.Color.White;
            this.Bill_btnOK.Image = null;
            this.Bill_btnOK.ImageSize = new System.Drawing.Size(20, 20);
            this.Bill_btnOK.Location = new System.Drawing.Point(954, 629);
            this.Bill_btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bill_btnOK.Name = "Bill_btnOK";
            this.Bill_btnOK.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Bill_btnOK.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Bill_btnOK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Bill_btnOK.OnHoverForeColor = System.Drawing.Color.White;
            this.Bill_btnOK.OnHoverImage = null;
            this.Bill_btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.Bill_btnOK.Radius = 3;
            this.Bill_btnOK.Size = new System.Drawing.Size(370, 57);
            this.Bill_btnOK.TabIndex = 6;
            this.Bill_btnOK.Text = "OK";
            this.Bill_btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bill_btnOK.Click += new System.EventHandler(this.Bill_btnOK_Click);
            // 
            // txtBorrowUpdate_LibrarianID
            // 
            this.txtBorrowUpdate_LibrarianID.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowUpdate_LibrarianID.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBorrowUpdate_LibrarianID.BorderColor = System.Drawing.Color.Silver;
            this.txtBorrowUpdate_LibrarianID.BorderSize = 0;
            this.txtBorrowUpdate_LibrarianID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowUpdate_LibrarianID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBorrowUpdate_LibrarianID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBorrowUpdate_LibrarianID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBorrowUpdate_LibrarianID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowUpdate_LibrarianID.Location = new System.Drawing.Point(921, 21);
            this.txtBorrowUpdate_LibrarianID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowUpdate_LibrarianID.Name = "txtBorrowUpdate_LibrarianID";
            this.txtBorrowUpdate_LibrarianID.PasswordChar = '\0';
            this.txtBorrowUpdate_LibrarianID.Radius = 3;
            this.txtBorrowUpdate_LibrarianID.ReadOnly = true;
            this.txtBorrowUpdate_LibrarianID.SelectedText = "";
            this.txtBorrowUpdate_LibrarianID.Size = new System.Drawing.Size(273, 46);
            this.txtBorrowUpdate_LibrarianID.TabIndex = 3;
            // 
            // txtBorrowUpdate_ID
            // 
            this.txtBorrowUpdate_ID.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowUpdate_ID.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBorrowUpdate_ID.BorderColor = System.Drawing.Color.White;
            this.txtBorrowUpdate_ID.BorderSize = 0;
            this.txtBorrowUpdate_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowUpdate_ID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBorrowUpdate_ID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBorrowUpdate_ID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBorrowUpdate_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowUpdate_ID.Location = new System.Drawing.Point(81, 21);
            this.txtBorrowUpdate_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowUpdate_ID.Name = "txtBorrowUpdate_ID";
            this.txtBorrowUpdate_ID.PasswordChar = '\0';
            this.txtBorrowUpdate_ID.Radius = 3;
            this.txtBorrowUpdate_ID.ReadOnly = true;
            this.txtBorrowUpdate_ID.SelectedText = "";
            this.txtBorrowUpdate_ID.Size = new System.Drawing.Size(273, 46);
            this.txtBorrowUpdate_ID.TabIndex = 1;
            // 
            // Bill_btnCancel
            // 
            this.Bill_btnCancel.AnimationHoverSpeed = 0.07F;
            this.Bill_btnCancel.AnimationSpeed = 0.03F;
            this.Bill_btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.Bill_btnCancel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.Bill_btnCancel.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.Bill_btnCancel.BorderColor = System.Drawing.Color.Black;
            this.Bill_btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Bill_btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.Bill_btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Bill_btnCancel.ForeColor = System.Drawing.Color.White;
            this.Bill_btnCancel.Image = null;
            this.Bill_btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.Bill_btnCancel.Location = new System.Drawing.Point(578, 629);
            this.Bill_btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bill_btnCancel.Name = "Bill_btnCancel";
            this.Bill_btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Bill_btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Bill_btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Bill_btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.Bill_btnCancel.OnHoverImage = null;
            this.Bill_btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.Bill_btnCancel.Radius = 3;
            this.Bill_btnCancel.Size = new System.Drawing.Size(370, 57);
            this.Bill_btnCancel.TabIndex = 7;
            this.Bill_btnCancel.Text = "Cancel";
            this.Bill_btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bill_btnCancel.Click += new System.EventHandler(this.Bill_btnCancel_Click);
            // 
            // panelBorrowUpdate_Information
            // 
            this.panelBorrowUpdate_Information.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBorrowUpdate_Information.Controls.Add(this.dtpBorrowUpdate_PayDate);
            this.panelBorrowUpdate_Information.Controls.Add(this.dtpBorrowUpdate_BorrowDate);
            this.panelBorrowUpdate_Information.Controls.Add(this.lblBorrowUpdate_PayDate);
            this.panelBorrowUpdate_Information.Controls.Add(this.lblBorrowUpdate_BorrowDate);
            this.panelBorrowUpdate_Information.Controls.Add(this.BorrowUpdate_MemberCard);
            this.panelBorrowUpdate_Information.Controls.Add(this.txtBorrowUpdate_TagNumber);
            this.panelBorrowUpdate_Information.Controls.Add(this.lblBorrowUpdate_LibrarianID);
            this.panelBorrowUpdate_Information.Controls.Add(this.BorrowUpdate_BorrowID);
            this.panelBorrowUpdate_Information.Controls.Add(this.txtBorrowUpdate_LibrarianID);
            this.panelBorrowUpdate_Information.Controls.Add(this.txtBorrowUpdate_ID);
            this.panelBorrowUpdate_Information.Location = new System.Drawing.Point(8, 101);
            this.panelBorrowUpdate_Information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBorrowUpdate_Information.Name = "panelBorrowUpdate_Information";
            this.panelBorrowUpdate_Information.Size = new System.Drawing.Size(1321, 206);
            this.panelBorrowUpdate_Information.TabIndex = 70;
            // 
            // frmBorow_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 695);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.Bill_btnOK);
            this.Controls.Add(this.Bill_btnCancel);
            this.Controls.Add(this.panelBorrowUpdate_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(325, 170);
            this.Name = "frmBorow_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Borow_Bill";
            this.Load += new System.EventHandler(this.frmBorow_Bill_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panelBorrowUpdate_Information.ResumeLayout(false);
            this.panelBorrowUpdate_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colSoLuong;
        private Guna.UI.WinForms.GunaDateTimePicker dtpBorrowUpdate_PayDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtpBorrowUpdate_BorrowDate;
        private System.Windows.Forms.Label lblBorrowUpdate_PayDate;
        private System.Windows.Forms.Label lblBorrowUpdate_BorrowDate;
        private System.Windows.Forms.Label BorrowUpdate_MemberCard;
        private Guna.UI.WinForms.GunaTextBox txtBorrowUpdate_TagNumber;
        private System.Windows.Forms.Label lblBorrowUpdate_LibrarianID;
        private System.Windows.Forms.Label BorrowUpdate_BorrowID;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton Bill_btnOK;
        private Guna.UI.WinForms.GunaTextBox txtBorrowUpdate_LibrarianID;
        private Guna.UI.WinForms.GunaTextBox txtBorrowUpdate_ID;
        private Guna.UI.WinForms.GunaGradientButton Bill_btnCancel;
        private System.Windows.Forms.Panel panelBorrowUpdate_Information;
    }
}