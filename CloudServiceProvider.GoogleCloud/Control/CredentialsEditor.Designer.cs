namespace CloudServiceProvider.GoogleCloud {
    partial class CredentialsEditor {
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
            this.FolderNameLabel = new CustomDialogs.DarkLabel();
            this.FolderNameTextBox = new CustomDialogs.DarkTextBox();
            this.BucketNameLabel = new CustomDialogs.DarkLabel();
            this.BucketNameTextBox = new CustomDialogs.DarkTextBox();
            this.JsonCredentialsLabel = new System.Windows.Forms.Label();
            this.RichTextBoxContainer = new System.Windows.Forms.Panel();
            this.RichTextBox = new CustomDialogs.DarkRichTextBox();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.RichTextBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.AutoSize = true;
            this.FolderNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameLabel.Location = new System.Drawing.Point(10, 285);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(73, 15);
            this.FolderNameLabel.TabIndex = 63;
            this.FolderNameLabel.Text = "Folder name";
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FolderNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameTextBox.Location = new System.Drawing.Point(13, 304);
            this.FolderNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.FolderNameTextBox.PasswordChar = '\0';
            this.FolderNameTextBox.ReadOnly = false;
            this.FolderNameTextBox.Size = new System.Drawing.Size(409, 25);
            this.FolderNameTextBox.TabIndex = 62;
            this.FolderNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderNameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameTextBox.XOffset = 0;
            this.FolderNameTextBox.YOffset = 0;
            // 
            // BucketNameLabel
            // 
            this.BucketNameLabel.AutoSize = true;
            this.BucketNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameLabel.Location = new System.Drawing.Point(10, 216);
            this.BucketNameLabel.Name = "BucketNameLabel";
            this.BucketNameLabel.Size = new System.Drawing.Size(76, 15);
            this.BucketNameLabel.TabIndex = 55;
            this.BucketNameLabel.Text = "Bucket name";
            // 
            // BucketNameTextBox
            // 
            this.BucketNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BucketNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BucketNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.Location = new System.Drawing.Point(13, 235);
            this.BucketNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BucketNameTextBox.Name = "BucketNameTextBox";
            this.BucketNameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.BucketNameTextBox.PasswordChar = '\0';
            this.BucketNameTextBox.ReadOnly = false;
            this.BucketNameTextBox.Size = new System.Drawing.Size(409, 25);
            this.BucketNameTextBox.TabIndex = 54;
            this.BucketNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.XOffset = 0;
            this.BucketNameTextBox.YOffset = 0;
            // 
            // JsonCredentialsLabel
            // 
            this.JsonCredentialsLabel.AutoSize = true;
            this.JsonCredentialsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.JsonCredentialsLabel.Location = new System.Drawing.Point(9, 9);
            this.JsonCredentialsLabel.Name = "JsonCredentialsLabel";
            this.JsonCredentialsLabel.Size = new System.Drawing.Size(90, 15);
            this.JsonCredentialsLabel.TabIndex = 53;
            this.JsonCredentialsLabel.Text = "Json credentials";
            // 
            // RichTextBoxContainer
            // 
            this.RichTextBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxContainer.Controls.Add(this.RichTextBox);
            this.RichTextBoxContainer.Location = new System.Drawing.Point(12, 29);
            this.RichTextBoxContainer.Name = "RichTextBoxContainer";
            this.RichTextBoxContainer.Size = new System.Drawing.Size(411, 172);
            this.RichTextBoxContainer.TabIndex = 52;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.RichTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.NonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBox.NonDisabledForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Size = new System.Drawing.Size(409, 170);
            this.RichTextBox.TabIndex = 2;
            this.RichTextBox.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(99, 378);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 65;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(12, 378);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 64;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CredentialsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(440, 423);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FolderNameLabel);
            this.Controls.Add(this.FolderNameTextBox);
            this.Controls.Add(this.BucketNameLabel);
            this.Controls.Add(this.BucketNameTextBox);
            this.Controls.Add(this.JsonCredentialsLabel);
            this.Controls.Add(this.RichTextBoxContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CredentialsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CredentialsEditor_FormClosing);
            this.RichTextBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkLabel FolderNameLabel;
        private CustomDialogs.DarkTextBox FolderNameTextBox;
        private CustomDialogs.DarkLabel BucketNameLabel;
        private CustomDialogs.DarkTextBox BucketNameTextBox;
        private System.Windows.Forms.Label JsonCredentialsLabel;
        private System.Windows.Forms.Panel RichTextBoxContainer;
        private CustomDialogs.DarkRichTextBox RichTextBox;
        private CustomDialogs.DarkButton CancelButton;
        private CustomDialogs.DarkButton SaveButton;
    }
}