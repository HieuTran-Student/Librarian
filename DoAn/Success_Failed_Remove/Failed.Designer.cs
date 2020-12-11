namespace DoAn.Success_Failed
{
    partial class frmFailed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFailed));
            this.lblFailed_Message = new System.Windows.Forms.Label();
            this.panelFailed = new Guna.UI.WinForms.GunaPanel();
            this.picFailed_Icon = new System.Windows.Forms.PictureBox();
            this.btnFailed_OK = new Guna.UI.WinForms.GunaGradientButton();
            this.panelFailed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFailed_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFailed_Message
            // 
            this.lblFailed_Message.AutoSize = true;
            this.lblFailed_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailed_Message.Location = new System.Drawing.Point(151, 16);
            this.lblFailed_Message.Name = "lblFailed_Message";
            this.lblFailed_Message.Size = new System.Drawing.Size(279, 55);
            this.lblFailed_Message.TabIndex = 46;
            this.lblFailed_Message.Text = "Add Failed !";
            this.lblFailed_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFailed
            // 
            this.panelFailed.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFailed.Controls.Add(this.picFailed_Icon);
            this.panelFailed.Controls.Add(this.lblFailed_Message);
            this.panelFailed.Location = new System.Drawing.Point(15, 15);
            this.panelFailed.Name = "panelFailed";
            this.panelFailed.Size = new System.Drawing.Size(570, 170);
            this.panelFailed.TabIndex = 47;
            // 
            // picFailed_Icon
            // 
            this.picFailed_Icon.BackColor = System.Drawing.Color.Gainsboro;
            this.picFailed_Icon.Image = ((System.Drawing.Image)(resources.GetObject("picFailed_Icon.Image")));
            this.picFailed_Icon.Location = new System.Drawing.Point(240, 88);
            this.picFailed_Icon.Name = "picFailed_Icon";
            this.picFailed_Icon.Size = new System.Drawing.Size(100, 70);
            this.picFailed_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFailed_Icon.TabIndex = 47;
            this.picFailed_Icon.TabStop = false;
            // 
            // btnFailed_OK
            // 
            this.btnFailed_OK.AnimationHoverSpeed = 0.07F;
            this.btnFailed_OK.AnimationSpeed = 0.03F;
            this.btnFailed_OK.BackColor = System.Drawing.Color.Transparent;
            this.btnFailed_OK.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnFailed_OK.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnFailed_OK.BorderColor = System.Drawing.Color.Black;
            this.btnFailed_OK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFailed_OK.FocusedColor = System.Drawing.Color.Empty;
            this.btnFailed_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailed_OK.ForeColor = System.Drawing.Color.White;
            this.btnFailed_OK.Image = null;
            this.btnFailed_OK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFailed_OK.Location = new System.Drawing.Point(118, 221);
            this.btnFailed_OK.Name = "btnFailed_OK";
            this.btnFailed_OK.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnFailed_OK.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnFailed_OK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFailed_OK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFailed_OK.OnHoverImage = null;
            this.btnFailed_OK.OnPressedColor = System.Drawing.Color.Black;
            this.btnFailed_OK.Radius = 3;
            this.btnFailed_OK.Size = new System.Drawing.Size(370, 57);
            this.btnFailed_OK.TabIndex = 51;
            this.btnFailed_OK.Text = "OK";
            this.btnFailed_OK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFailed_OK.Click += new System.EventHandler(this.btnFailed_OK_Click);
            // 
            // frmFailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnFailed_OK);
            this.Controls.Add(this.panelFailed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 320);
            this.Name = "frmFailed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Success";
            this.panelFailed.ResumeLayout(false);
            this.panelFailed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFailed_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFailed_Message;
        private Guna.UI.WinForms.GunaPanel panelFailed;
        private Guna.UI.WinForms.GunaGradientButton btnFailed_OK;
        private System.Windows.Forms.PictureBox picFailed_Icon;
    }
}