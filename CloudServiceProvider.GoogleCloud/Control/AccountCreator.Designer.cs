namespace CloudServiceProvider.GoogleCloud {
    partial class AccountCreator {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCreator));
            this.JsonCredentialsLabel = new System.Windows.Forms.Label();
            this.RichTextBoxContainer = new System.Windows.Forms.Panel();
            this.RichTextBox = new CustomDialogs.DarkRichTextBox();
            this.BucketNameLabel = new CustomDialogs.DarkLabel();
            this.BucketNameTextBox = new CustomDialogs.DarkTextBox();
            this.EmailLabel = new CustomDialogs.DarkLabel();
            this.EmailTextBox = new CustomDialogs.DarkTextBox();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.CreateAccountButton = new CustomDialogs.DarkButton();
            this.CanelButton = new CustomDialogs.DarkButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderNameLabel = new CustomDialogs.DarkLabel();
            this.FolderNameTextBox = new CustomDialogs.DarkTextBox();
            this.RichTextBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // JsonCredentialsLabel
            // 
            this.JsonCredentialsLabel.AutoSize = true;
            this.JsonCredentialsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.JsonCredentialsLabel.Location = new System.Drawing.Point(10, 8);
            this.JsonCredentialsLabel.Name = "JsonCredentialsLabel";
            this.JsonCredentialsLabel.Size = new System.Drawing.Size(90, 15);
            this.JsonCredentialsLabel.TabIndex = 6;
            this.JsonCredentialsLabel.Text = "Json credentials";
            // 
            // RichTextBoxContainer
            // 
            this.RichTextBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxContainer.Controls.Add(this.RichTextBox);
            this.RichTextBoxContainer.Location = new System.Drawing.Point(13, 28);
            this.RichTextBoxContainer.Name = "RichTextBoxContainer";
            this.RichTextBoxContainer.Size = new System.Drawing.Size(411, 172);
            this.RichTextBoxContainer.TabIndex = 5;
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
            // BucketNameLabel
            // 
            this.BucketNameLabel.AutoSize = true;
            this.BucketNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameLabel.Location = new System.Drawing.Point(11, 215);
            this.BucketNameLabel.Name = "BucketNameLabel";
            this.BucketNameLabel.Size = new System.Drawing.Size(76, 15);
            this.BucketNameLabel.TabIndex = 41;
            this.BucketNameLabel.Text = "Bucket name";
            // 
            // BucketNameTextBox
            // 
            this.BucketNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BucketNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BucketNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.Location = new System.Drawing.Point(14, 234);
            this.BucketNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BucketNameTextBox.Name = "BucketNameTextBox";
            this.BucketNameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.BucketNameTextBox.PasswordChar = '\0';
            this.BucketNameTextBox.ReadOnly = false;
            this.BucketNameTextBox.Size = new System.Drawing.Size(409, 25);
            this.BucketNameTextBox.TabIndex = 40;
            this.BucketNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.XOffset = 0;
            this.BucketNameTextBox.YOffset = 0;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailLabel.Location = new System.Drawing.Point(10, 290);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 43;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailTextBox.Location = new System.Drawing.Point(13, 309);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.Size = new System.Drawing.Size(197, 25);
            this.EmailTextBox.TabIndex = 42;
            this.EmailTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailTextBox.XOffset = 0;
            this.EmailTextBox.YOffset = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(224, 290);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 45;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(227, 309);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(197, 25);
            this.NameTextBox.TabIndex = 44;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(14, 352);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(50, 50);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 46;
            this.PictureBox.TabStop = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(74, 377);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 47;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CreateAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateAccountButton.Location = new System.Drawing.Point(14, 454);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(101, 25);
            this.CreateAccountButton.TabIndex = 48;
            this.CreateAccountButton.Text = "Create account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CanelButton
            // 
            this.CanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CanelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CanelButton.Location = new System.Drawing.Point(129, 454);
            this.CanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CanelButton.Name = "CanelButton";
            this.CanelButton.Size = new System.Drawing.Size(75, 25);
            this.CanelButton.TabIndex = 49;
            this.CanelButton.Text = "Cancel";
            this.CanelButton.UseVisualStyleBackColor = false;
            this.CanelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png;*.jpeg";
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.AutoSize = true;
            this.FolderNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameLabel.Location = new System.Drawing.Point(224, 358);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(73, 15);
            this.FolderNameLabel.TabIndex = 51;
            this.FolderNameLabel.Text = "Folder name";
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FolderNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameTextBox.Location = new System.Drawing.Point(227, 377);
            this.FolderNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.FolderNameTextBox.PasswordChar = '\0';
            this.FolderNameTextBox.ReadOnly = false;
            this.FolderNameTextBox.Size = new System.Drawing.Size(197, 25);
            this.FolderNameTextBox.TabIndex = 50;
            this.FolderNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderNameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderNameTextBox.XOffset = 0;
            this.FolderNameTextBox.YOffset = 0;
            // 
            // AccountCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(439, 500);
            this.Controls.Add(this.FolderNameLabel);
            this.Controls.Add(this.FolderNameTextBox);
            this.Controls.Add(this.CanelButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BucketNameLabel);
            this.Controls.Add(this.BucketNameTextBox);
            this.Controls.Add(this.JsonCredentialsLabel);
            this.Controls.Add(this.RichTextBoxContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create account";
            this.RichTextBoxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JsonCredentialsLabel;
        private System.Windows.Forms.Panel RichTextBoxContainer;
        private CustomDialogs.DarkRichTextBox RichTextBox;
        private CustomDialogs.DarkLabel BucketNameLabel;
        private CustomDialogs.DarkTextBox BucketNameTextBox;
        private CustomDialogs.DarkLabel EmailLabel;
        private CustomDialogs.DarkTextBox EmailTextBox;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private CustomDialogs.DarkButton BrowseButton;
        private CustomDialogs.DarkButton CreateAccountButton;
        private CustomDialogs.DarkButton CanelButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private CustomDialogs.DarkLabel FolderNameLabel;
        private CustomDialogs.DarkTextBox FolderNameTextBox;
    }
}