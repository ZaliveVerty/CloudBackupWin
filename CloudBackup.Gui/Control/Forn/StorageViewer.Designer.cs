
namespace CloudBackup.Gui {
    partial class StorageViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageViewer));
            this.CloseButton = new CustomDialogs.DarkButton();
            this.BarPanel = new System.Windows.Forms.Panel();
            this.UsedPanel = new System.Windows.Forms.Panel();
            this.CapacityLabel = new CustomDialogs.DarkLabel();
            this.UsedLabel = new CustomDialogs.DarkLabel();
            this.CapacityLabelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PercentageContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PercentageLabel = new CustomDialogs.DarkLabel();
            this.BarPanel.SuspendLayout();
            this.CapacityLabelContainer.SuspendLayout();
            this.PercentageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(14, 70);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(83, 25);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BarPanel
            // 
            this.BarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarPanel.Controls.Add(this.UsedPanel);
            this.BarPanel.Location = new System.Drawing.Point(14, 32);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(360, 11);
            this.BarPanel.TabIndex = 1;
            // 
            // UsedPanel
            // 
            this.UsedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.UsedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UsedPanel.Location = new System.Drawing.Point(0, 0);
            this.UsedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UsedPanel.Name = "UsedPanel";
            this.UsedPanel.Size = new System.Drawing.Size(0, 9);
            this.UsedPanel.TabIndex = 0;
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CapacityLabel.Location = new System.Drawing.Point(227, 0);
            this.CapacityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(0, 15);
            this.CapacityLabel.TabIndex = 2;
            this.CapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UsedLabel.Location = new System.Drawing.Point(11, 14);
            this.UsedLabel.Name = "UsedLabel";
            this.UsedLabel.Size = new System.Drawing.Size(0, 15);
            this.UsedLabel.TabIndex = 3;
            // 
            // CapacityLabelContainer
            // 
            this.CapacityLabelContainer.ColumnCount = 1;
            this.CapacityLabelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CapacityLabelContainer.Controls.Add(this.CapacityLabel, 0, 0);
            this.CapacityLabelContainer.Location = new System.Drawing.Point(151, 46);
            this.CapacityLabelContainer.Name = "CapacityLabelContainer";
            this.CapacityLabelContainer.RowCount = 1;
            this.CapacityLabelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CapacityLabelContainer.Size = new System.Drawing.Size(227, 18);
            this.CapacityLabelContainer.TabIndex = 4;
            // 
            // PercentageContainer
            // 
            this.PercentageContainer.ColumnCount = 1;
            this.PercentageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PercentageContainer.Controls.Add(this.PercentageLabel, 0, 0);
            this.PercentageContainer.Location = new System.Drawing.Point(271, 14);
            this.PercentageContainer.Name = "PercentageContainer";
            this.PercentageContainer.RowCount = 1;
            this.PercentageContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PercentageContainer.Size = new System.Drawing.Size(107, 18);
            this.PercentageContainer.TabIndex = 5;
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PercentageLabel.Location = new System.Drawing.Point(107, 0);
            this.PercentageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(0, 15);
            this.PercentageLabel.TabIndex = 2;
            this.PercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StorageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(388, 110);
            this.Controls.Add(this.PercentageContainer);
            this.Controls.Add(this.CapacityLabelContainer);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.BarPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StorageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            this.BarPanel.ResumeLayout(false);
            this.CapacityLabelContainer.ResumeLayout(false);
            this.CapacityLabelContainer.PerformLayout();
            this.PercentageContainer.ResumeLayout(false);
            this.PercentageContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.Panel BarPanel;
        private CustomDialogs.DarkLabel CapacityLabel;
        private CustomDialogs.DarkLabel UsedLabel;
        private System.Windows.Forms.Panel UsedPanel;
        private System.Windows.Forms.TableLayoutPanel CapacityLabelContainer;
        private System.Windows.Forms.TableLayoutPanel PercentageContainer;
        private CustomDialogs.DarkLabel PercentageLabel;
    }
}