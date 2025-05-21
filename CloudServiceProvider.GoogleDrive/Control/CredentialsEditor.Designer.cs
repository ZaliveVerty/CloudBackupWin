
namespace CloudServiceProvider.GoogleDrive {
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
            this.SaveButton = new CustomDialogs.DarkButton();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.RichTextBox = new CustomDialogs.DarkRichTextBox();
            this.RichTextBoxContainer = new System.Windows.Forms.Panel();
            this.JsonCredentialsLabel = new System.Windows.Forms.Label();
            this.RichTextBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(13, 232);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(100, 233);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 24);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // RichTextBoxContainer
            // 
            this.RichTextBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxContainer.Controls.Add(this.RichTextBox);
            this.RichTextBoxContainer.Location = new System.Drawing.Point(13, 28);
            this.RichTextBoxContainer.Name = "RichTextBoxContainer";
            this.RichTextBoxContainer.Size = new System.Drawing.Size(411, 172);
            this.RichTextBoxContainer.TabIndex = 3;
            // 
            // JsonCredentialsLabel
            // 
            this.JsonCredentialsLabel.AutoSize = true;
            this.JsonCredentialsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.JsonCredentialsLabel.Location = new System.Drawing.Point(10, 8);
            this.JsonCredentialsLabel.Name = "JsonCredentialsLabel";
            this.JsonCredentialsLabel.Size = new System.Drawing.Size(90, 15);
            this.JsonCredentialsLabel.TabIndex = 4;
            this.JsonCredentialsLabel.Text = "Json credentials";
            // 
            // CredentialsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(437, 271);
            this.Controls.Add(this.JsonCredentialsLabel);
            this.Controls.Add(this.RichTextBoxContainer);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "CredentialsEditor";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creentials";
            this.RichTextBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomDialogs.DarkButton CancelButton;
        private CustomDialogs.DarkButton SaveButton;
        private CustomDialogs.DarkRichTextBox RichTextBox;
        private System.Windows.Forms.Panel RichTextBoxContainer;
        private System.Windows.Forms.Label JsonCredentialsLabel;
    }
}