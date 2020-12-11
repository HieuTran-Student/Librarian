namespace DoAn.Book_Borrow_Reader.Book.Add_Update_Book
{
    partial class frmBook_Category
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
            this.panelCategory = new Guna.UI.WinForms.GunaPanel();
            this.lblCATEGORY = new System.Windows.Forms.Label();
            this.btnBook_NewCategory = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBook_CategoryCancel = new Guna.UI.WinForms.GunaGradientButton();
            this.txtBook_CategoryID = new System.Windows.Forms.Label();
            this.txtBook_CategoryName = new Guna.UI.WinForms.GunaTextBox();
            this.lblBook_CategoryName = new System.Windows.Forms.Label();
            this.lblBook_CategoryID = new System.Windows.Forms.Label();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCategory.Controls.Add(this.lblCATEGORY);
            this.panelCategory.Controls.Add(this.btnBook_NewCategory);
            this.panelCategory.Controls.Add(this.btnBook_CategoryCancel);
            this.panelCategory.Controls.Add(this.txtBook_CategoryID);
            this.panelCategory.Controls.Add(this.txtBook_CategoryName);
            this.panelCategory.Controls.Add(this.lblBook_CategoryName);
            this.panelCategory.Controls.Add(this.lblBook_CategoryID);
            this.panelCategory.Location = new System.Drawing.Point(12, 12);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(504, 264);
            this.panelCategory.TabIndex = 51;
            // 
            // lblCATEGORY
            // 
            this.lblCATEGORY.AutoSize = true;
            this.lblCATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCATEGORY.Location = new System.Drawing.Point(181, 23);
            this.lblCATEGORY.Name = "lblCATEGORY";
            this.lblCATEGORY.Size = new System.Drawing.Size(150, 38);
            this.lblCATEGORY.TabIndex = 59;
            this.lblCATEGORY.Text = "Category";
            // 
            // btnBook_NewCategory
            // 
            this.btnBook_NewCategory.AnimationHoverSpeed = 0.07F;
            this.btnBook_NewCategory.AnimationSpeed = 0.03F;
            this.btnBook_NewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_NewCategory.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_NewCategory.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_NewCategory.BorderColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_NewCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_NewCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook_NewCategory.ForeColor = System.Drawing.Color.White;
            this.btnBook_NewCategory.Image = null;
            this.btnBook_NewCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBook_NewCategory.Location = new System.Drawing.Point(343, 215);
            this.btnBook_NewCategory.Name = "btnBook_NewCategory";
            this.btnBook_NewCategory.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_NewCategory.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_NewCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_NewCategory.OnHoverImage = null;
            this.btnBook_NewCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.Radius = 3;
            this.btnBook_NewCategory.Size = new System.Drawing.Size(145, 38);
            this.btnBook_NewCategory.TabIndex = 2;
            this.btnBook_NewCategory.Text = "New Category";
            this.btnBook_NewCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_NewCategory.Click += new System.EventHandler(this.btnBook_NewCategory_Click);
            // 
            // btnBook_CategoryCancel
            // 
            this.btnBook_CategoryCancel.AnimationHoverSpeed = 0.07F;
            this.btnBook_CategoryCancel.AnimationSpeed = 0.03F;
            this.btnBook_CategoryCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_CategoryCancel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_CategoryCancel.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_CategoryCancel.BorderColor = System.Drawing.Color.Black;
            this.btnBook_CategoryCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_CategoryCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_CategoryCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook_CategoryCancel.ForeColor = System.Drawing.Color.White;
            this.btnBook_CategoryCancel.Image = null;
            this.btnBook_CategoryCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBook_CategoryCancel.Location = new System.Drawing.Point(208, 215);
            this.btnBook_CategoryCancel.Name = "btnBook_CategoryCancel";
            this.btnBook_CategoryCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_CategoryCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_CategoryCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_CategoryCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_CategoryCancel.OnHoverImage = null;
            this.btnBook_CategoryCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_CategoryCancel.Radius = 3;
            this.btnBook_CategoryCancel.Size = new System.Drawing.Size(113, 38);
            this.btnBook_CategoryCancel.TabIndex = 3;
            this.btnBook_CategoryCancel.Text = "Cancel";
            this.btnBook_CategoryCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_CategoryCancel.Click += new System.EventHandler(this.btnBook_CategoryCancel_Click);
            // 
            // txtBook_CategoryID
            // 
            this.txtBook_CategoryID.AutoSize = true;
            this.txtBook_CategoryID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBook_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook_CategoryID.Location = new System.Drawing.Point(192, 103);
            this.txtBook_CategoryID.Margin = new System.Windows.Forms.Padding(3);
            this.txtBook_CategoryID.Name = "txtBook_CategoryID";
            this.txtBook_CategoryID.Padding = new System.Windows.Forms.Padding(5);
            this.txtBook_CategoryID.Size = new System.Drawing.Size(138, 35);
            this.txtBook_CategoryID.TabIndex = 56;
            this.txtBook_CategoryID.Text = "DS00000009";
            // 
            // txtBook_CategoryName
            // 
            this.txtBook_CategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txtBook_CategoryName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBook_CategoryName.BorderColor = System.Drawing.Color.White;
            this.txtBook_CategoryName.BorderSize = 0;
            this.txtBook_CategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBook_CategoryName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBook_CategoryName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBook_CategoryName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBook_CategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook_CategoryName.Location = new System.Drawing.Point(188, 155);
            this.txtBook_CategoryName.Name = "txtBook_CategoryName";
            this.txtBook_CategoryName.PasswordChar = '\0';
            this.txtBook_CategoryName.Radius = 3;
            this.txtBook_CategoryName.SelectedText = "";
            this.txtBook_CategoryName.Size = new System.Drawing.Size(290, 37);
            this.txtBook_CategoryName.TabIndex = 1;
            // 
            // lblBook_CategoryName
            // 
            this.lblBook_CategoryName.AutoSize = true;
            this.lblBook_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_CategoryName.Location = new System.Drawing.Point(18, 167);
            this.lblBook_CategoryName.Name = "lblBook_CategoryName";
            this.lblBook_CategoryName.Size = new System.Drawing.Size(155, 25);
            this.lblBook_CategoryName.TabIndex = 48;
            this.lblBook_CategoryName.Text = "Category Name:";
            // 
            // lblBook_CategoryID
            // 
            this.lblBook_CategoryID.AutoSize = true;
            this.lblBook_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_CategoryID.Location = new System.Drawing.Point(18, 113);
            this.lblBook_CategoryID.Name = "lblBook_CategoryID";
            this.lblBook_CategoryID.Size = new System.Drawing.Size(122, 25);
            this.lblBook_CategoryID.TabIndex = 47;
            this.lblBook_CategoryID.Text = "Category ID:";
            // 
            // frmBook_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 286);
            this.Controls.Add(this.panelCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 320);
            this.Name = "frmBook_Category";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book Category";
            this.Load += new System.EventHandler(this.frmBook_Category_Load);
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelCategory;
        private System.Windows.Forms.Label lblBook_CategoryName;
        private System.Windows.Forms.Label lblBook_CategoryID;
        private Guna.UI.WinForms.GunaTextBox txtBook_CategoryName;
        private System.Windows.Forms.Label txtBook_CategoryID;
        private Guna.UI.WinForms.GunaGradientButton btnBook_NewCategory;
        private Guna.UI.WinForms.GunaGradientButton btnBook_CategoryCancel;
        private System.Windows.Forms.Label lblCATEGORY;
    }
}