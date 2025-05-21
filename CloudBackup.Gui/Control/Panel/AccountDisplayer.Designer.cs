
namespace CloudBackup.Gui {
    partial class AccountDisplayer {
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
            this.AccountPictureBox = new System.Windows.Forms.PictureBox();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.ProviderNameLabel = new CustomDialogs.DarkLabel();
            this.SeperatorLabel = new CustomDialogs.DarkLabel();
            this.EmailLabel = new CustomDialogs.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBox)).BeginInit();
            this.GlobalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountPictureBox
            // 
            this.AccountPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountPictureBox.Location = new System.Drawing.Point(0, 5);
            this.AccountPictureBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.AccountPictureBox.Name = "AccountPictureBox";
            this.AccountPictureBox.Size = new System.Drawing.Size(18, 18);
            this.AccountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AccountPictureBox.TabIndex = 1;
            this.AccountPictureBox.TabStop = false;
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.AutoSize = true;
            this.GlobalContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalContainer.ColumnCount = 5;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GlobalContainer.Controls.Add(this.ProfilePictureBox, 3, 0);
            this.GlobalContainer.Controls.Add(this.AccountPictureBox, 0, 0);
            this.GlobalContainer.Controls.Add(this.ProviderNameLabel, 1, 0);
            this.GlobalContainer.Controls.Add(this.SeperatorLabel, 2, 0);
            this.GlobalContainer.Controls.Add(this.EmailLabel, 4, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Size = new System.Drawing.Size(327, 27);
            this.GlobalContainer.TabIndex = 2;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfilePictureBox.Location = new System.Drawing.Point(31, 5);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(18, 18);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 5;
            this.ProfilePictureBox.TabStop = false;
            // 
            // ProviderNameLabel
            // 
            this.ProviderNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProviderNameLabel.AutoSize = true;
            this.ProviderNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProviderNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProviderNameLabel.Location = new System.Drawing.Point(19, 6);
            this.ProviderNameLabel.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.ProviderNameLabel.Name = "ProviderNameLabel";
            this.ProviderNameLabel.Size = new System.Drawing.Size(0, 15);
            this.ProviderNameLabel.TabIndex = 2;
            // 
            // SeperatorLabel
            // 
            this.SeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeperatorLabel.AutoSize = true;
            this.SeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SeperatorLabel.Location = new System.Drawing.Point(19, 6);
            this.SeperatorLabel.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.SeperatorLabel.Name = "SeperatorLabel";
            this.SeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.SeperatorLabel.TabIndex = 4;
            this.SeperatorLabel.Text = "|";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailLabel.Location = new System.Drawing.Point(50, 6);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 15);
            this.EmailLabel.TabIndex = 6;
            // 
            // AccountDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Name = "AccountDisplayer";
            this.Size = new System.Drawing.Size(327, 27);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBox)).EndInit();
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AccountPictureBox;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkLabel ProviderNameLabel;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private CustomDialogs.DarkLabel SeperatorLabel;
        private CustomDialogs.DarkLabel EmailLabel;
    }
}
