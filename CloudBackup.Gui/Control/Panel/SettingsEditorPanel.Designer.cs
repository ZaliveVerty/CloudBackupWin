
namespace CloudBackup.Gui {
    partial class SettingsEditorPanel {
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
            this.AccountDisplayer = new CloudBackup.Gui.AccountDisplayer();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ChangePathInDriveButton = new CustomDialogs.DarkButton();
            this.SelectOwnerButton = new CustomDialogs.DarkButton();
            this.ChangeLinkButton = new CustomDialogs.DarkButton();
            this.ChangePasswordButton = new CustomDialogs.DarkButton();
            this.GlobalContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.AccountDisplayer, 0, 1);
            this.GlobalContainer.Controls.Add(this.ButtonPanel, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(290, 81);
            this.GlobalContainer.TabIndex = 0;
            // 
            // AccountDisplayer
            // 
            this.AccountDisplayer.Account = null;
            this.AccountDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AccountDisplayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountDisplayer.Location = new System.Drawing.Point(3, 51);
            this.AccountDisplayer.Name = "AccountDisplayer";
            this.AccountDisplayer.Size = new System.Drawing.Size(284, 27);
            this.AccountDisplayer.TabIndex = 39;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ChangePathInDriveButton);
            this.ButtonPanel.Controls.Add(this.SelectOwnerButton);
            this.ButtonPanel.Controls.Add(this.ChangeLinkButton);
            this.ButtonPanel.Controls.Add(this.ChangePasswordButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(290, 48);
            this.ButtonPanel.TabIndex = 40;
            // 
            // ChangePathInDriveButton
            // 
            this.ChangePathInDriveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangePathInDriveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangePathInDriveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePathInDriveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePathInDriveButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxTreeView;
            this.ChangePathInDriveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePathInDriveButton.Location = new System.Drawing.Point(167, 1);
            this.ChangePathInDriveButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePathInDriveButton.Name = "ChangePathInDriveButton";
            this.ChangePathInDriveButton.Size = new System.Drawing.Size(59, 25);
            this.ChangePathInDriveButton.TabIndex = 41;
            this.ChangePathInDriveButton.Text = "Path";
            this.ChangePathInDriveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePathInDriveButton.UseVisualStyleBackColor = true;
            this.ChangePathInDriveButton.Click += new System.EventHandler(this.ChangePathInDriveButton_Click);
            // 
            // SelectOwnerButton
            // 
            this.SelectOwnerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SelectOwnerButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectOwnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectOwnerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectOwnerButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxUserProfile;
            this.SelectOwnerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectOwnerButton.Location = new System.Drawing.Point(1, 1);
            this.SelectOwnerButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectOwnerButton.Name = "SelectOwnerButton";
            this.SelectOwnerButton.Size = new System.Drawing.Size(70, 25);
            this.SelectOwnerButton.TabIndex = 40;
            this.SelectOwnerButton.Text = "Owner";
            this.SelectOwnerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectOwnerButton.UseVisualStyleBackColor = false;
            this.SelectOwnerButton.Click += new System.EventHandler(this.SelectAccountButton_Click);
            // 
            // ChangeLinkButton
            // 
            this.ChangeLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangeLinkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLinkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeLinkButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxLink;
            this.ChangeLinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeLinkButton.Location = new System.Drawing.Point(232, 1);
            this.ChangeLinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLinkButton.Name = "ChangeLinkButton";
            this.ChangeLinkButton.Size = new System.Drawing.Size(57, 25);
            this.ChangeLinkButton.TabIndex = 39;
            this.ChangeLinkButton.Text = "Link";
            this.ChangeLinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeLinkButton.UseVisualStyleBackColor = true;
            this.ChangeLinkButton.Click += new System.EventHandler(this.ChangeLinkButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxKey;
            this.ChangePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordButton.Location = new System.Drawing.Point(77, 1);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(84, 25);
            this.ChangePasswordButton.TabIndex = 38;
            this.ChangePasswordButton.Text = "Password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // SettingsPanelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SettingsPanelEditor";
            this.Size = new System.Drawing.Size(290, 81);
            this.GlobalContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private AccountDisplayer AccountDisplayer;
        private System.Windows.Forms.Panel ButtonPanel;
        private CustomDialogs.DarkButton ChangeLinkButton;
        private CustomDialogs.DarkButton ChangePasswordButton;
        private CustomDialogs.DarkButton SelectOwnerButton;
        private CustomDialogs.DarkButton ChangePathInDriveButton;
    }
}
