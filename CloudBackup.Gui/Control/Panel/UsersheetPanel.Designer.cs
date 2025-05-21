
namespace CloudBackup.Gui {
    partial class UsersheetPanel {
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
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadLink = new System.Windows.Forms.LinkLabel();
            this.OpenInBrowserLink = new System.Windows.Forms.LinkLabel();
            this.AccountPanel = new CloudBackup.Gui.AccountDisplayer();
            this.GlobalContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 3;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.GlobalContainer.Controls.Add(this.DownloadLink, 1, 0);
            this.GlobalContainer.Controls.Add(this.OpenInBrowserLink, 2, 0);
            this.GlobalContainer.Controls.Add(this.AccountPanel, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(8, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Size = new System.Drawing.Size(425, 31);
            this.GlobalContainer.TabIndex = 0;
            // 
            // DownloadLink
            // 
            this.DownloadLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.DownloadLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DownloadLink.AutoSize = true;
            this.DownloadLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownloadLink.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.DownloadLink.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.DownloadLink.Location = new System.Drawing.Point(280, 9);
            this.DownloadLink.Margin = new System.Windows.Forms.Padding(0);
            this.DownloadLink.Name = "DownloadLink";
            this.DownloadLink.Size = new System.Drawing.Size(55, 13);
            this.DownloadLink.TabIndex = 8;
            this.DownloadLink.TabStop = true;
            this.DownloadLink.Text = "Download";
            this.DownloadLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DownloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DownloadLink_LinkClicked);
            // 
            // OpenInBrowserLink
            // 
            this.OpenInBrowserLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.OpenInBrowserLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenInBrowserLink.AutoSize = true;
            this.OpenInBrowserLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenInBrowserLink.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.OpenInBrowserLink.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.OpenInBrowserLink.Location = new System.Drawing.Point(341, 9);
            this.OpenInBrowserLink.Margin = new System.Windows.Forms.Padding(0);
            this.OpenInBrowserLink.Name = "OpenInBrowserLink";
            this.OpenInBrowserLink.Size = new System.Drawing.Size(84, 13);
            this.OpenInBrowserLink.TabIndex = 9;
            this.OpenInBrowserLink.TabStop = true;
            this.OpenInBrowserLink.Text = "Open in browser";
            this.OpenInBrowserLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.OpenInBrowserLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenInBrowserLink_LinkClicked);
            // 
            // AccountPanel
            // 
            this.AccountPanel.Account = null;
            this.AccountPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AccountPanel.Location = new System.Drawing.Point(0, 2);
            this.AccountPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(280, 27);
            this.AccountPanel.TabIndex = 10;
            // 
            // UsersheetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.GlobalContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsersheetPanel";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.Size = new System.Drawing.Size(438, 31);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.LinkLabel DownloadLink;
        private System.Windows.Forms.LinkLabel OpenInBrowserLink;
        private AccountDisplayer AccountPanel;
    }
}
