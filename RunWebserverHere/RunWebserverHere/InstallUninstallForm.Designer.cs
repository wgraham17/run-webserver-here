namespace RunWebserverHere
{
    partial class InstallUninstallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallUninstallForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::RunWebserverHere.Properties.Resources.LogoImage;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 45);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(288, 33);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "RunWebserverHere";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(146, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 225);
            this.panel1.TabIndex = 2;
            // 
            // InstallUninstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InstallUninstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunWebserverHere";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
    }
}