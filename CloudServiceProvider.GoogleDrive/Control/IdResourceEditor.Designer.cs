
namespace CloudServiceProvider.GoogleDrive {
    partial class IdResourceEditor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ClearCacheButton = new CustomDialogs.DarkButton();
            this.RefreshButton = new CustomDialogs.DarkButton();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.InformationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GridView = new CustomDialogs.DarkDataGridView();
            this.FileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailPanel = new System.Windows.Forms.Panel();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.SelectEmailLabel = new CustomDialogs.DarkLabel();
            this.CopyToClipboardLabel = new System.Windows.Forms.LinkLabel();
            this.GlobalContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.EmailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ButtonPanel, 0, 1);
            this.GlobalContainer.Controls.Add(this.InformationPanel, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(828, 461);
            this.GlobalContainer.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoSize = true;
            this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPanel.Controls.Add(this.CopyToClipboardLabel);
            this.ButtonPanel.Controls.Add(this.ClearCacheButton);
            this.ButtonPanel.Controls.Add(this.RefreshButton);
            this.ButtonPanel.Controls.Add(this.CloseButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 427);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(828, 34);
            this.ButtonPanel.TabIndex = 2;
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearCacheButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClearCacheButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClearCacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCacheButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearCacheButton.Location = new System.Drawing.Point(730, 6);
            this.ClearCacheButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(98, 25);
            this.ClearCacheButton.TabIndex = 2;
            this.ClearCacheButton.Text = "Clear cache";
            this.ClearCacheButton.UseVisualStyleBackColor = false;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RefreshButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshButton.Location = new System.Drawing.Point(86, 9);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(0, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InformationPanel
            // 
            this.InformationPanel.ColumnCount = 1;
            this.InformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationPanel.Controls.Add(this.GridView, 0, 1);
            this.InformationPanel.Controls.Add(this.EmailPanel, 0, 0);
            this.InformationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationPanel.Location = new System.Drawing.Point(0, 0);
            this.InformationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.RowCount = 2;
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationPanel.Size = new System.Drawing.Size(828, 425);
            this.InformationPanel.TabIndex = 3;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameCol,
            this.IdCol});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.Location = new System.Drawing.Point(0, 60);
            this.GridView.Margin = new System.Windows.Forms.Padding(0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(828, 365);
            this.GridView.TabIndex = 0;
            // 
            // FileNameCol
            // 
            this.FileNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileNameCol.HeaderText = "File Name";
            this.FileNameCol.Name = "FileNameCol";
            this.FileNameCol.ReadOnly = true;
            // 
            // IdCol
            // 
            this.IdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.IdCol.DefaultCellStyle = dataGridViewCellStyle14;
            this.IdCol.HeaderText = "File ID";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            this.IdCol.Width = 63;
            // 
            // EmailPanel
            // 
            this.EmailPanel.AutoSize = true;
            this.EmailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmailPanel.Controls.Add(this.EmailComboBox);
            this.EmailPanel.Controls.Add(this.SelectEmailLabel);
            this.EmailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailPanel.Location = new System.Drawing.Point(0, 0);
            this.EmailPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.EmailPanel.Name = "EmailPanel";
            this.EmailPanel.Size = new System.Drawing.Size(828, 50);
            this.EmailPanel.TabIndex = 1;
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Location = new System.Drawing.Point(0, 22);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(225, 25);
            this.EmailComboBox.TabIndex = 1;
            this.EmailComboBox.SelectedIndexChanged += new System.EventHandler(this.EmailComboBox_SelectedIndexChanged);
            // 
            // SelectEmailLabel
            // 
            this.SelectEmailLabel.AutoSize = true;
            this.SelectEmailLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectEmailLabel.Location = new System.Drawing.Point(-3, 4);
            this.SelectEmailLabel.Name = "SelectEmailLabel";
            this.SelectEmailLabel.Size = new System.Drawing.Size(106, 15);
            this.SelectEmailLabel.TabIndex = 0;
            this.SelectEmailLabel.Text = "Select visible email";
            // 
            // CopyToClipboardLabel
            // 
            this.CopyToClipboardLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyToClipboardLabel.AutoSize = true;
            this.CopyToClipboardLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyToClipboardLabel.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyToClipboardLabel.Location = new System.Drawing.Point(176, 16);
            this.CopyToClipboardLabel.Name = "CopyToClipboardLabel";
            this.CopyToClipboardLabel.Size = new System.Drawing.Size(102, 15);
            this.CopyToClipboardLabel.TabIndex = 3;
            this.CopyToClipboardLabel.TabStop = true;
            this.CopyToClipboardLabel.Text = "Copy to clipboard";
            this.CopyToClipboardLabel.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyToClipboardLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyToClipboardLabel_LinkClicked);
            // 
            // IdResourceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(848, 481);
            this.Controls.Add(this.GlobalContainer);
            this.Name = "IdResourceViewer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cache viewer";
            this.Load += new System.EventHandler(this.IdResourceViewer_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.EmailPanel.ResumeLayout(false);
            this.EmailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private CustomDialogs.DarkButton RefreshButton;
        private System.Windows.Forms.TableLayoutPanel InformationPanel;
        private CustomDialogs.DarkDataGridView GridView;
        private System.Windows.Forms.Panel EmailPanel;
        private System.Windows.Forms.ComboBox EmailComboBox;
        private CustomDialogs.DarkLabel SelectEmailLabel;
        private CustomDialogs.DarkButton ClearCacheButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.LinkLabel CopyToClipboardLabel;
    }
}