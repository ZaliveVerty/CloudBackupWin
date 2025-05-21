
namespace CloudBackup.Gui {
    partial class CloudProviderPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CloudNameLabel = new System.Windows.Forms.Label();
            this.CloudLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloudLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloudNameLabel
            // 
            this.CloudNameLabel.AutoSize = true;
            this.CloudNameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloudNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloudNameLabel.Location = new System.Drawing.Point(49, 7);
            this.CloudNameLabel.Name = "CloudNameLabel";
            this.CloudNameLabel.Size = new System.Drawing.Size(109, 23);
            this.CloudNameLabel.TabIndex = 3;
            this.CloudNameLabel.Text = "Google Drive";
            // 
            // CloudLogoPictureBox
            // 
            this.CloudLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloudLogoPictureBox.Location = new System.Drawing.Point(5, 5);
            this.CloudLogoPictureBox.Name = "CloudLogoPictureBox";
            this.CloudLogoPictureBox.Size = new System.Drawing.Size(38, 38);
            this.CloudLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloudLogoPictureBox.TabIndex = 2;
            this.CloudLogoPictureBox.TabStop = false;
            // 
            // CloudProviderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.CloudNameLabel);
            this.Controls.Add(this.CloudLogoPictureBox);
            this.Name = "CloudProviderPanel";
            this.Size = new System.Drawing.Size(336, 48);
            ((System.ComponentModel.ISupportInitialize)(this.CloudLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloudNameLabel;
        private System.Windows.Forms.PictureBox CloudLogoPictureBox;
    }
}
