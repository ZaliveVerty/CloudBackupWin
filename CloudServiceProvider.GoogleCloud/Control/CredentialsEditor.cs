using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleCloud {
    public partial class CredentialsEditor : Form {
        public Credentials Credentials { get; private set; }

        private bool _close = false;

        public CredentialsEditor(Credentials credentials) {
            InitializeComponent();

            Credentials = credentials;

            RichTextBox.Text = Credentials.AccountCredentials.CredentialsJsonString;
            BucketNameTextBox.Text = Credentials.AccountCredentials.BucketName;
            FolderNameTextBox.Text = credentials.FolderName;

            Icon = ImageToIconConverter.Convert(Properties.Resources._16pxCredentials, 64, 64);
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveChanges();

            _close = true;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private void CredentialsEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (_close || !CheckForChanges()) return;

            SaveConfirmation result = CustomDialog.ShowSaveConfirmation();
            if (result == SaveConfirmation.Close || result == SaveConfirmation.Cancel) {
                e.Cancel = true;
                return;
            }
            if (result == SaveConfirmation.DontSave) return;

            if (!ValidateContent()) {
                e.Cancel = true;
                return;
            }

            SaveChanges();
        }

        private bool CheckForChanges() {
            if (RichTextBox.Text != Credentials.AccountCredentials.CredentialsJsonString ||
                BucketNameTextBox.Text != Credentials.AccountCredentials.BucketName) return true;

            return FolderNameTextBox.Text != Credentials.FolderName;
        }
        private bool ValidateContent() {
            if (string.IsNullOrEmpty(RichTextBox.Text)) {
                CustomDialog.ShowError("Credentials error", "Credentials json string cannot be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(BucketNameTextBox.Text)) {
                CustomDialog.ShowError("Bucket name error", "Bucket name cannot be empty.");
                return false;
            }

            return true;
        }
        private void SaveChanges() {
            Credentials.ApplyUpdateMode();

            Credentials.AccountCredentials.CredentialsJsonString = RichTextBox.Text;
            Credentials.AccountCredentials.BucketName = BucketNameTextBox.Text;
            Credentials.FolderName = FolderNameTextBox.Text;

            Credentials.SuspendUpdateMode();
        }
    }
}
