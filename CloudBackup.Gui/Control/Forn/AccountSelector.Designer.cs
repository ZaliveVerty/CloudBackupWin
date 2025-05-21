
namespace CloudBackup.Gui {
    partial class AccountSelector {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSelector));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CloudLabel = new CustomDialogs.DarkLabel();
            this.AccountLabel = new CustomDialogs.DarkLabel();
            this.AccountContainer = new System.Windows.Forms.TableLayoutPanel();
            this.AddAccountButton = new CustomDialogs.DarkButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeselectButton = new CustomDialogs.DarkButton();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.RemoveAccountButton = new CustomDialogs.DarkButton();
            this.GlobalContainer.SuspendLayout();
            this.HeaderContainer.SuspendLayout();
            this.AccountContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.HeaderContainer, 0, 0);
            this.GlobalContainer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(669, 252);
            this.GlobalContainer.TabIndex = 0;
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.ColumnCount = 3;
            this.HeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.HeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderContainer.Controls.Add(this.CloudLabel, 0, 0);
            this.HeaderContainer.Controls.Add(this.AccountLabel, 2, 0);
            this.HeaderContainer.Controls.Add(this.AccountContainer, 2, 1);
            this.HeaderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderContainer.Location = new System.Drawing.Point(3, 3);
            this.HeaderContainer.Name = "HeaderContainer";
            this.HeaderContainer.RowCount = 2;
            this.HeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.HeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderContainer.Size = new System.Drawing.Size(663, 221);
            this.HeaderContainer.TabIndex = 0;
            // 
            // CloudLabel
            // 
            this.CloudLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloudLabel.AutoSize = true;
            this.CloudLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloudLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloudLabel.Location = new System.Drawing.Point(0, 2);
            this.CloudLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.CloudLabel.Name = "CloudLabel";
            this.CloudLabel.Size = new System.Drawing.Size(108, 20);
            this.CloudLabel.TabIndex = 1;
            this.CloudLabel.Text = "Cloud provider";
            // 
            // AccountLabel
            // 
            this.AccountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AccountLabel.Location = new System.Drawing.Point(336, 2);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(69, 20);
            this.AccountLabel.TabIndex = 2;
            this.AccountLabel.Text = "Accounts";
            // 
            // AccountContainer
            // 
            this.AccountContainer.AutoScroll = true;
            this.AccountContainer.AutoSize = true;
            this.AccountContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountContainer.ColumnCount = 1;
            this.AccountContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountContainer.Controls.Add(this.AddAccountButton, 0, 1);
            this.AccountContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountContainer.Location = new System.Drawing.Point(336, 25);
            this.AccountContainer.Margin = new System.Windows.Forms.Padding(0);
            this.AccountContainer.Name = "AccountContainer";
            this.AccountContainer.RowCount = 2;
            this.AccountContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountContainer.Size = new System.Drawing.Size(327, 25);
            this.AccountContainer.TabIndex = 3;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddAccountButton.Location = new System.Drawing.Point(0, 0);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(96, 25);
            this.AddAccountButton.TabIndex = 0;
            this.AddAccountButton.Text = "Add account";
            this.AddAccountButton.UseVisualStyleBackColor = false;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DeselectButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DoneButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveAccountButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 227);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 25);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DeselectButton
            // 
            this.DeselectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DeselectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(85, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(75, 25);
            this.DeselectButton.TabIndex = 3;
            this.DeselectButton.Text = "Deselect";
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(0, 0);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 25);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // RemoveAccountButton
            // 
            this.RemoveAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RemoveAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccountButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveAccountButton.Image = global::CloudBackup.Gui.Properties.Resources._16pxTrash;
            this.RemoveAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveAccountButton.Location = new System.Drawing.Point(547, 0);
            this.RemoveAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveAccountButton.Name = "RemoveAccountButton";
            this.RemoveAccountButton.Size = new System.Drawing.Size(122, 25);
            this.RemoveAccountButton.TabIndex = 2;
            this.RemoveAccountButton.Text = "Remove account";
            this.RemoveAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveAccountButton.UseVisualStyleBackColor = false;
            this.RemoveAccountButton.Click += new System.EventHandler(this.RemoveAccountButton_Click);
            // 
            // AccountSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(689, 262);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountSelector";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select account";
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.HeaderContainer.ResumeLayout(false);
            this.HeaderContainer.PerformLayout();
            this.AccountContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel HeaderContainer;
        private CustomDialogs.DarkLabel CloudLabel;
        private CustomDialogs.DarkLabel AccountLabel;
        private CustomDialogs.DarkButton DoneButton;
        private System.Windows.Forms.TableLayoutPanel AccountContainer;
        private CustomDialogs.DarkButton AddAccountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomDialogs.DarkButton RemoveAccountButton;
        private CustomDialogs.DarkButton DeselectButton;
    }
}