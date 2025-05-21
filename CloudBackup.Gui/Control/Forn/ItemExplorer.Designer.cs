
namespace CloudBackup.Gui {
    partial class ItemExplorer {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            CustomDialogs.CustomToolStripRenderer customToolStripRenderer1 = new CustomDialogs.CustomToolStripRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.AccountDisplayer = new CloudBackup.Gui.AccountDisplayer();
            this.ManageAccountsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CloseSeperatorLabel = new CustomDialogs.DarkLabel();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.InformationSeperator = new CustomDialogs.DarkLabel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.MoveUpSeperator = new CustomDialogs.DarkLabel();
            this.MoreButton = new System.Windows.Forms.Button();
            this.ViewControl = new CustomDialogs.ViewControl();
            this.MoreMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItemsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateSchemesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSheetManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadUserSheetSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewgroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFilteredFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItemBundleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.OpenInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInNewWindowSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageOwnerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathInDriveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathInDriveSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.MoreMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Controls.Add(this.ViewControl, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(1, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(862, 496);
            this.GlobalContainer.TabIndex = 1;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 13;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.Controls.Add(this.AccountDisplayer, 1, 0);
            this.BottomContainer.Controls.Add(this.ManageAccountsButton, 0, 0);
            this.BottomContainer.Controls.Add(this.CloseButton, 12, 0);
            this.BottomContainer.Controls.Add(this.CloseSeperatorLabel, 10, 0);
            this.BottomContainer.Controls.Add(this.ChangeKeyButton, 9, 0);
            this.BottomContainer.Controls.Add(this.InformationButton, 8, 0);
            this.BottomContainer.Controls.Add(this.DeselectButton, 11, 0);
            this.BottomContainer.Controls.Add(this.InformationSeperator, 7, 0);
            this.BottomContainer.Controls.Add(this.MoveDownButton, 6, 0);
            this.BottomContainer.Controls.Add(this.MoveUpButton, 5, 0);
            this.BottomContainer.Controls.Add(this.MoveUpSeperator, 4, 0);
            this.BottomContainer.Controls.Add(this.MoreButton, 3, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(7, 471);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(848, 23);
            this.BottomContainer.TabIndex = 4;
            // 
            // AccountDisplayer
            // 
            this.AccountDisplayer.Account = null;
            this.AccountDisplayer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountDisplayer.AutoSize = true;
            this.AccountDisplayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AccountDisplayer.Location = new System.Drawing.Point(75, 1);
            this.AccountDisplayer.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.AccountDisplayer.Name = "AccountDisplayer";
            this.AccountDisplayer.Size = new System.Drawing.Size(38, 20);
            this.AccountDisplayer.TabIndex = 5;
            // 
            // ManageAccountsButton
            // 
            this.ManageAccountsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManageAccountsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManageAccountsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ManageAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageAccountsButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageAccountsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManageAccountsButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxUserProfile;
            this.ManageAccountsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageAccountsButton.Location = new System.Drawing.Point(0, 0);
            this.ManageAccountsButton.Margin = new System.Windows.Forms.Padding(0);
            this.ManageAccountsButton.Name = "ManageAccountsButton";
            this.ManageAccountsButton.Size = new System.Drawing.Size(68, 23);
            this.ManageAccountsButton.TabIndex = 6;
            this.ManageAccountsButton.Text = "Profile";
            this.ManageAccountsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageAccountsButton.UseVisualStyleBackColor = false;
            this.ManageAccountsButton.Click += new System.EventHandler(this.ManageAccountsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(783, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.ToolTip.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CloseSeperatorLabel
            // 
            this.CloseSeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseSeperatorLabel.AutoSize = true;
            this.CloseSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CloseSeperatorLabel.Location = new System.Drawing.Point(736, 3);
            this.CloseSeperatorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.CloseSeperatorLabel.Name = "CloseSeperatorLabel";
            this.CloseSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.CloseSeperatorLabel.TabIndex = 8;
            this.CloseSeperatorLabel.Text = "|";
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeKeyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeKeyButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxKey;
            this.ChangeKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeKeyButton.Location = new System.Drawing.Point(629, 0);
            this.ChangeKeyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeKeyButton.TabIndex = 9;
            this.ChangeKeyButton.Text = "Change key";
            this.ChangeKeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.ChangeKeyButton, "Change current key");
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InformationButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxInformation;
            this.InformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InformationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformationButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationButton.Location = new System.Drawing.Point(599, 0);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(23, 23);
            this.InformationButton.TabIndex = 10;
            this.ToolTip.SetToolTip(this.InformationButton, "Information about the program");
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeselectButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxDeselect;
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(753, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 11;
            this.ToolTip.SetToolTip(this.DeselectButton, "Clear selection");
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // InformationSeperator
            // 
            this.InformationSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationSeperator.AutoSize = true;
            this.InformationSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.InformationSeperator.Location = new System.Drawing.Point(581, 3);
            this.InformationSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.InformationSeperator.Name = "InformationSeperator";
            this.InformationSeperator.Size = new System.Drawing.Size(10, 15);
            this.InformationSeperator.TabIndex = 12;
            this.InformationSeperator.Text = "|";
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveDownButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveDownButton.Location = new System.Drawing.Point(549, 0);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(23, 23);
            this.MoveDownButton.TabIndex = 13;
            this.ToolTip.SetToolTip(this.MoveDownButton, "Move selected item down by one row");
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveUpButton.BackgroundImage = global::CloudBackup.Gui.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveUpButton.Location = new System.Drawing.Point(519, 0);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(23, 23);
            this.MoveUpButton.TabIndex = 14;
            this.ToolTip.SetToolTip(this.MoveUpButton, "Move selected item up by one row");
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // MoveUpSeperator
            // 
            this.MoveUpSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveUpSeperator.AutoSize = true;
            this.MoveUpSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.MoveUpSeperator.Location = new System.Drawing.Point(501, 3);
            this.MoveUpSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.MoveUpSeperator.Name = "MoveUpSeperator";
            this.MoveUpSeperator.Size = new System.Drawing.Size(10, 15);
            this.MoveUpSeperator.TabIndex = 15;
            this.MoveUpSeperator.Text = "|";
            // 
            // MoreButton
            // 
            this.MoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoreButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoreButton.Location = new System.Drawing.Point(442, 0);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(50, 23);
            this.MoreButton.TabIndex = 16;
            this.MoreButton.Text = "More";
            this.ToolTip.SetToolTip(this.MoreButton, "More tools");
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // ViewControl
            // 
            this.ViewControl.AutoSize = true;
            this.ViewControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewControl.Location = new System.Drawing.Point(7, 6);
            this.ViewControl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewControl.Name = "ViewControl";
            this.ViewControl.Size = new System.Drawing.Size(848, 463);
            this.ViewControl.TabIndex = 5;
            // 
            // MoreMenuStrip
            // 
            this.MoreMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MoreMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportItemsMenuItem,
            this.ImportItemsMenuItem,
            this.ImportItemsSeparator,
            this.UpdateSchemesMenuItem,
            this.UserSheetManagerMenuItem,
            this.DownloadUserSheetSeparator,
            this.SettingsMenuItem});
            this.MoreMenuStrip.Name = "MoreMenuStrip";
            this.MoreMenuStrip.Size = new System.Drawing.Size(179, 126);
            // 
            // ExportItemsMenuItem
            // 
            this.ExportItemsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportItemsMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxExport;
            this.ExportItemsMenuItem.Name = "ExportItemsMenuItem";
            this.ExportItemsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ExportItemsMenuItem.Text = "Export items";
            this.ExportItemsMenuItem.Click += new System.EventHandler(this.ExportItemsMenuItem_Click);
            // 
            // ImportItemsMenuItem
            // 
            this.ImportItemsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImportItemsMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxImport;
            this.ImportItemsMenuItem.Name = "ImportItemsMenuItem";
            this.ImportItemsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ImportItemsMenuItem.Text = "Import items";
            this.ImportItemsMenuItem.Click += new System.EventHandler(this.ImportItemsMenuItem_Click);
            // 
            // ImportItemsSeparator
            // 
            this.ImportItemsSeparator.Name = "ImportItemsSeparator";
            this.ImportItemsSeparator.Size = new System.Drawing.Size(175, 6);
            // 
            // UpdateSchemesMenuItem
            // 
            this.UpdateSchemesMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateSchemesMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCloudUpload;
            this.UpdateSchemesMenuItem.Name = "UpdateSchemesMenuItem";
            this.UpdateSchemesMenuItem.Size = new System.Drawing.Size(178, 22);
            this.UpdateSchemesMenuItem.Text = "Update schemes";
            this.UpdateSchemesMenuItem.Click += new System.EventHandler(this.UpdateSchemesMenuItem_Click);
            // 
            // UserSheetManagerMenuItem
            // 
            this.UserSheetManagerMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserSheetManagerMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxExportToExcel;
            this.UserSheetManagerMenuItem.Name = "UserSheetManagerMenuItem";
            this.UserSheetManagerMenuItem.Size = new System.Drawing.Size(178, 22);
            this.UserSheetManagerMenuItem.Text = "User sheet manager";
            this.UserSheetManagerMenuItem.Click += new System.EventHandler(this.UserSheetManagerMenuItem_Click);
            // 
            // DownloadUserSheetSeparator
            // 
            this.DownloadUserSheetSeparator.Name = "DownloadUserSheetSeparator";
            this.DownloadUserSheetSeparator.Size = new System.Drawing.Size(175, 6);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SettingsMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxSettings;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(178, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            customToolStripRenderer1.RoundedEdges = true;
            this.MenuStrip.CustomRenderer = customToolStripRenderer1;
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeparator,
            this.OpenInNewWindowMenuItem,
            this.OpenInNewWindowSeparator,
            this.UpdateMenuItem,
            this.DownloadMenuItem,
            this.DownloadSeparator,
            this.ChangePasswordMenuItem,
            this.ManageOwnerMenuItem,
            this.SetPathInDriveMenuItem,
            this.SetPathInDriveSeparator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeparator,
            this.MoveMenuItem,
            this.EditMenuItem,
            this.RenameMenuItem,
            this.DeleteMenuItem,
            this.DeleteSeparator,
            this.PropertiesMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(201, 348);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewgroupMenuItem,
            this.NewGroupSeperator,
            this.NewFolderMenuItem,
            this.NewFilteredFolderMenuItem,
            this.NewItemBundleMenuItem});
            this.NewMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewMenuItem.Text = "New                                  ";
            // 
            // NewgroupMenuItem
            // 
            this.NewgroupMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxMenuStripGroup;
            this.NewgroupMenuItem.Name = "NewgroupMenuItem";
            this.NewgroupMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewgroupMenuItem.Text = "Group                               ";
            this.NewgroupMenuItem.Click += new System.EventHandler(this.NewGroupMenuItem_Click);
            // 
            // NewGroupSeperator
            // 
            this.NewGroupSeperator.Name = "NewGroupSeperator";
            this.NewGroupSeperator.Size = new System.Drawing.Size(197, 6);
            // 
            // NewFolderMenuItem
            // 
            this.NewFolderMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxFolderClosed;
            this.NewFolderMenuItem.Name = "NewFolderMenuItem";
            this.NewFolderMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewFolderMenuItem.Text = "Folder";
            this.NewFolderMenuItem.Click += new System.EventHandler(this.NewFolderMenuItem_Click);
            // 
            // NewFilteredFolderMenuItem
            // 
            this.NewFilteredFolderMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxFilteredFolder;
            this.NewFilteredFolderMenuItem.Name = "NewFilteredFolderMenuItem";
            this.NewFilteredFolderMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewFilteredFolderMenuItem.Text = "Fiiltered folder";
            this.NewFilteredFolderMenuItem.Click += new System.EventHandler(this.NewFilteredFolderMenuItem_Click);
            // 
            // NewItemBundleMenuItem
            // 
            this.NewItemBundleMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxItemBundle;
            this.NewItemBundleMenuItem.Name = "NewItemBundleMenuItem";
            this.NewItemBundleMenuItem.Size = new System.Drawing.Size(200, 22);
            this.NewItemBundleMenuItem.Text = "Item bundle";
            this.NewItemBundleMenuItem.Click += new System.EventHandler(this.NewItemBundleMenuItem_Click);
            // 
            // NewSeparator
            // 
            this.NewSeparator.Name = "NewSeparator";
            this.NewSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // OpenInNewWindowMenuItem
            // 
            this.OpenInNewWindowMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxApplication;
            this.OpenInNewWindowMenuItem.Name = "OpenInNewWindowMenuItem";
            this.OpenInNewWindowMenuItem.Size = new System.Drawing.Size(200, 22);
            this.OpenInNewWindowMenuItem.Text = "Open in new window";
            this.OpenInNewWindowMenuItem.Click += new System.EventHandler(this.OpenInNewWindowMenuItem_Click);
            // 
            // OpenInNewWindowSeparator
            // 
            this.OpenInNewWindowSeparator.Name = "OpenInNewWindowSeparator";
            this.OpenInNewWindowSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCloudUpload;
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(200, 22);
            this.UpdateMenuItem.Text = "Update";
            this.UpdateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
            // 
            // DownloadMenuItem
            // 
            this.DownloadMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxDownload;
            this.DownloadMenuItem.Name = "DownloadMenuItem";
            this.DownloadMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DownloadMenuItem.Text = "Download";
            this.DownloadMenuItem.Click += new System.EventHandler(this.DownloadMenuItem_Click);
            // 
            // DownloadSeparator
            // 
            this.DownloadSeparator.Name = "DownloadSeparator";
            this.DownloadSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxPasswordStrength;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ChangePasswordMenuItem.Text = "Change password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // ManageOwnerMenuItem
            // 
            this.ManageOwnerMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxUserProfile;
            this.ManageOwnerMenuItem.Name = "ManageOwnerMenuItem";
            this.ManageOwnerMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ManageOwnerMenuItem.Text = "Manage owner";
            this.ManageOwnerMenuItem.Click += new System.EventHandler(this.ManageOwnerMenuItem_Click);
            // 
            // SetPathInDriveMenuItem
            // 
            this.SetPathInDriveMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxTreeView;
            this.SetPathInDriveMenuItem.Name = "SetPathInDriveMenuItem";
            this.SetPathInDriveMenuItem.Size = new System.Drawing.Size(200, 22);
            this.SetPathInDriveMenuItem.Text = "Set path in drive";
            this.SetPathInDriveMenuItem.Click += new System.EventHandler(this.SetPathInDriveMenuItem_Click);
            // 
            // SetPathInDriveSeparator
            // 
            this.SetPathInDriveSeparator.Name = "SetPathInDriveSeparator";
            this.SetPathInDriveSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(200, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(200, 22);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // PasteSeparator
            // 
            this.PasteSeparator.Name = "PasteSeparator";
            this.PasteSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._64pxMove;
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(200, 22);
            this.MoveMenuItem.Text = "Move";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxEdit;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(200, 22);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // DeleteSeparator
            // 
            this.DeleteSeparator.Name = "DeleteSeparator";
            this.DeleteSeparator.Size = new System.Drawing.Size(197, 6);
            // 
            // PropertiesMenuItem
            // 
            this.PropertiesMenuItem.Image = global::CloudBackup.Gui.Properties.Resources._16pxProperty;
            this.PropertiesMenuItem.Name = "PropertiesMenuItem";
            this.PropertiesMenuItem.Size = new System.Drawing.Size(200, 22);
            this.PropertiesMenuItem.Text = "Properties";
            this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(864, 496);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemExplorer_FormClosing);
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.MoreMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private AccountDisplayer AccountDisplayer;
        private System.Windows.Forms.Button ManageAccountsButton;
        private System.Windows.Forms.Button CloseButton;
        private CustomDialogs.DarkLabel CloseSeperatorLabel;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button DeselectButton;
        private CustomDialogs.DarkLabel InformationSeperator;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private CustomDialogs.DarkLabel MoveUpSeperator;
        private System.Windows.Forms.Button MoreButton;
        private CustomDialogs.ViewControl ViewControl;
        private System.Windows.Forms.ContextMenuStrip MoreMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExportItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportItemsMenuItem;
        private System.Windows.Forms.ToolStripSeparator ImportItemsSeparator;
        private System.Windows.Forms.ToolStripMenuItem UpdateSchemesMenuItem;
        private System.Windows.Forms.ToolStripSeparator DownloadUserSheetSeparator;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserSheetManagerMenuItem;
        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewgroupMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewGroupSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFilteredFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewItemBundleMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeparator;
        private System.Windows.Forms.ToolStripMenuItem OpenInNewWindowMenuItem;
        private System.Windows.Forms.ToolStripSeparator OpenInNewWindowSeparator;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadMenuItem;
        private System.Windows.Forms.ToolStripSeparator DownloadSeparator;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageOwnerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetPathInDriveMenuItem;
        private System.Windows.Forms.ToolStripSeparator SetPathInDriveSeparator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeparator;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator DeleteSeparator;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
    }
}