
namespace CloudBackup.Gui {
    partial class AccountPanel {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPanel));
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FreeSpaceLabel = new System.Windows.Forms.Label();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.InfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderContainer = new System.Windows.Forms.TableLayoutPanel();
            this.StoragePanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.EmailContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SpacePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.storageInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.GlobalContainer.SuspendLayout();
            this.InfoContainer.SuspendLayout();
            this.HeaderContainer.SuspendLayout();
            this.StoragePanel.SuspendLayout();
            this.EmailContainer.SuspendLayout();
            this.SpacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(5, 5);
            this.ProfilePictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(38, 38);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayNameLabel.AutoSize = true;
            this.DisplayNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DisplayNameLabel.Location = new System.Drawing.Point(0, 6);
            this.DisplayNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(119, 19);
            this.DisplayNameLabel.TabIndex = 1;
            this.DisplayNameLabel.Text = "Miķelis Kalme - D.";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EmailLabel.Location = new System.Drawing.Point(1, 0);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(144, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "tawlerwood90@gmail.com";
            // 
            // FreeSpaceLabel
            // 
            this.FreeSpaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FreeSpaceLabel.AutoSize = true;
            this.FreeSpaceLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FreeSpaceLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FreeSpaceLabel.Location = new System.Drawing.Point(19, 0);
            this.FreeSpaceLabel.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.FreeSpaceLabel.Name = "FreeSpaceLabel";
            this.FreeSpaceLabel.Size = new System.Drawing.Size(0, 13);
            this.FreeSpaceLabel.TabIndex = 3;
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 2;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ProfilePictureBox, 0, 0);
            this.GlobalContainer.Controls.Add(this.InfoContainer, 1, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Size = new System.Drawing.Size(280, 48);
            this.GlobalContainer.TabIndex = 5;
            // 
            // InfoContainer
            // 
            this.InfoContainer.ColumnCount = 1;
            this.InfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoContainer.Controls.Add(this.HeaderContainer, 0, 0);
            this.InfoContainer.Controls.Add(this.EmailContainer, 0, 1);
            this.InfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoContainer.Location = new System.Drawing.Point(45, 0);
            this.InfoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.InfoContainer.Name = "InfoContainer";
            this.InfoContainer.RowCount = 2;
            this.InfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.InfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoContainer.Size = new System.Drawing.Size(235, 48);
            this.InfoContainer.TabIndex = 0;
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.ColumnCount = 2;
            this.HeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderContainer.Controls.Add(this.DisplayNameLabel, 0, 0);
            this.HeaderContainer.Controls.Add(this.StoragePanel, 1, 0);
            this.HeaderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.HeaderContainer.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderContainer.Name = "HeaderContainer";
            this.HeaderContainer.RowCount = 1;
            this.HeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderContainer.Size = new System.Drawing.Size(235, 28);
            this.HeaderContainer.TabIndex = 6;
            // 
            // StoragePanel
            // 
            this.StoragePanel.Controls.Add(this.RefreshButton);
            this.StoragePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoragePanel.Location = new System.Drawing.Point(119, 0);
            this.StoragePanel.Margin = new System.Windows.Forms.Padding(0);
            this.StoragePanel.Name = "StoragePanel";
            this.StoragePanel.Size = new System.Drawing.Size(116, 28);
            this.StoragePanel.TabIndex = 2;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources.Refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(96, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(17, 17);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // EmailContainer
            // 
            this.EmailContainer.ColumnCount = 2;
            this.EmailContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EmailContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmailContainer.Controls.Add(this.EmailLabel, 0, 0);
            this.EmailContainer.Controls.Add(this.SpacePanel, 1, 0);
            this.EmailContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailContainer.Location = new System.Drawing.Point(0, 28);
            this.EmailContainer.Margin = new System.Windows.Forms.Padding(0);
            this.EmailContainer.Name = "EmailContainer";
            this.EmailContainer.RowCount = 1;
            this.EmailContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmailContainer.Size = new System.Drawing.Size(235, 20);
            this.EmailContainer.TabIndex = 0;
            // 
            // SpacePanel
            // 
            this.SpacePanel.AutoSize = true;
            this.SpacePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpacePanel.ColumnCount = 2;
            this.SpacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SpacePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SpacePanel.Controls.Add(this.FreeSpaceLabel, 1, 0);
            this.SpacePanel.Controls.Add(this.LoadingPictureBox, 0, 0);
            this.SpacePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SpacePanel.Location = new System.Drawing.Point(215, 0);
            this.SpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SpacePanel.Name = "SpacePanel";
            this.SpacePanel.RowCount = 1;
            this.SpacePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SpacePanel.Size = new System.Drawing.Size(20, 20);
            this.SpacePanel.TabIndex = 3;
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPictureBox.Image")));
            this.LoadingPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LoadingPictureBox.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.LoadingPictureBox.Size = new System.Drawing.Size(13, 13);
            this.LoadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingPictureBox.TabIndex = 0;
            this.LoadingPictureBox.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storageInformationToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.ShowImageMargin = false;
            this.MenuStrip.Size = new System.Drawing.Size(156, 48);
            // 
            // storageInformationToolStripMenuItem
            // 
            this.storageInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.storageInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.storageInformationToolStripMenuItem.Name = "storageInformationToolStripMenuItem";
            this.storageInformationToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.storageInformationToolStripMenuItem.Text = "Storage information";
            this.storageInformationToolStripMenuItem.Click += new System.EventHandler(this.StorageInformationMenuItem_Click);
            // 
            // AccountPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ContextMenuStrip = this.MenuStrip;
            this.Controls.Add(this.GlobalContainer);
            this.MinimumSize = new System.Drawing.Size(200, 48);
            this.Name = "AccountPanel";
            this.Size = new System.Drawing.Size(280, 48);
            this.Load += new System.EventHandler(this.AccountPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.GlobalContainer.ResumeLayout(false);
            this.InfoContainer.ResumeLayout(false);
            this.HeaderContainer.ResumeLayout(false);
            this.HeaderContainer.PerformLayout();
            this.StoragePanel.ResumeLayout(false);
            this.EmailContainer.ResumeLayout(false);
            this.EmailContainer.PerformLayout();
            this.SpacePanel.ResumeLayout(false);
            this.SpacePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FreeSpaceLabel;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel InfoContainer;
        private System.Windows.Forms.TableLayoutPanel EmailContainer;
        private System.Windows.Forms.TableLayoutPanel HeaderContainer;
        private System.Windows.Forms.Panel StoragePanel;
        private System.Windows.Forms.PictureBox LoadingPictureBox;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem storageInformationToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel SpacePanel;
        private System.Windows.Forms.Button RefreshButton;
    }
}
