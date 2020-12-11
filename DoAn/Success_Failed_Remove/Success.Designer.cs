namespace DoAn.Success_Failed
{
    partial class frmSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuccess));
            this.lblSuccess_Message = new System.Windows.Forms.Label();
            this.btnSuccess_OK = new Guna.UI.WinForms.GunaGradientButton();
            this.panelSuccess = new Guna.UI.WinForms.GunaPanel();
            this.picSuccess_Icon = new System.Windows.Forms.PictureBox();
            this.panelSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuccess_Message
            // 
            this.lblSuccess_Message.AutoSize = true;
            this.lblSuccess_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess_Message.Location = new System.Drawing.Point(75, 15);
            this.lblSuccess_Message.Name = "lblSuccess_Message";
            this.lblSuccess_Message.Size = new System.Drawing.Size(415, 55);
            this.lblSuccess_Message.TabIndex = 46;
            this.lblSuccess_Message.Text = "Add Successfully !";
            this.lblSuccess_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSuccess_OK
            // 
            this.btnSuccess_OK.AnimationHoverSpeed = 0.07F;
            this.btnSuccess_OK.AnimationSpeed = 0.03F;
            this.btnSuccess_OK.BackColor = System.Drawing.Color.Transparent;
            this.btnSuccess_OK.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnSuccess_OK.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnSuccess_OK.BorderColor = System.Drawing.Color.Black;
            this.btnSuccess_OK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuccess_OK.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuccess_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccess_OK.ForeColor = System.Drawing.Color.White;
            this.btnSuccess_OK.Image = null;
            this.btnSuccess_OK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuccess_OK.Location = new System.Drawing.Point(162, 214);
            this.btnSuccess_OK.Name = "btnSuccess_OK";
            this.btnSuccess_OK.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSuccess_OK.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSuccess_OK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuccess_OK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuccess_OK.OnHoverImage = null;
            this.btnSuccess_OK.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuccess_OK.Radius = 3;
            this.btnSuccess_OK.Size = new System.Drawing.Size(370, 57);
            this.btnSuccess_OK.TabIndex = 53;
            this.btnSuccess_OK.Text = "OK";
            this.btnSuccess_OK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuccess_OK.Click += new System.EventHandler(this.btnSuccess_OK_Click);
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSuccess.Controls.Add(this.picSuccess_Icon);
            this.panelSuccess.Controls.Add(this.lblSuccess_Message);
            this.panelSuccess.Location = new System.Drawing.Point(12, 12);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(667, 170);
            this.panelSuccess.TabIndex = 52;
            // 
            // picSuccess_Icon
            // 
            this.picSuccess_Icon.BackColor = System.Drawing.Color.Gainsboro;
            this.picSuccess_Icon.Image = ((System.Drawing.Image)(resources.GetObject("picSuccess_Icon.Image")));
            this.picSuccess_Icon.Location = new System.Drawing.Point(288, 97);
            this.picSuccess_Icon.Name = "picSuccess_Icon";
            this.picSuccess_Icon.Size = new System.Drawing.Size(100, 70);
            this.picSuccess_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuccess_Icon.TabIndex = 47;
            this.picSuccess_Icon.TabStop = false;
            // 
            // frmSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(697, 295);
            this.Controls.Add(this.btnSuccess_OK);
            this.Controls.Add(this.panelSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 320);
            this.Name = "frmSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "falsed";
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSuccess_Message;
        private Guna.UI.WinForms.GunaGradientButton btnSuccess_OK;
        private Guna.UI.WinForms.GunaPanel panelSuccess;
        private System.Windows.Forms.PictureBox picSuccess_Icon;
    }
}