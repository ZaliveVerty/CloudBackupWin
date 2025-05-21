using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleCloud {
    public partial class AccountCreator : Form {
        public UserAccount CreatedAccount { get; private set; }
        public bool DialogClosed { get; private set; } = true;

        public CredentialsCatalog CredentialsCatalog { get; private set; }

        public AccountCreator(CredentialsCatalog credentialsCatalog) {
            InitializeComponent();

            CredentialsCatalog = credentialsCatalog;

            Icon = ImageToIconConverter.Convert(Properties.Resources._16pxUserProfile, 64, 64);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(OpenFileDialog.FileName)) return;

            PictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            CreatedAccount = new UserAccount() { 
                Credentials = new Credentials() { 
                    Email = EmailTextBox.Text,
                    Name = NameTextBox.Text,
                    FolderName = FolderNameTextBox.Text,
                    AccountCredentials = new Common.Credentials() { 
                        CredentialsJsonString = RichTextBox.Text,
                        BucketName = BucketNameTextBox.Text
                    }
                },
                Account = new Account() { 
                    Email = EmailTextBox.Text,
                    DisplayName = NameTextBox.Text,
                    ProfilePicture = PictureBox.Image == null ? null : PictureBox.Image.Resize(64, 64, InterpolationMode.HighQualityBicubic)
                }
            };

            DialogClosed = false;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private bool ValidateContents() {
            if (string.IsNullOrEmpty(RichTextBox.Text)) {
                CustomDialog.ShowError("Credentials error", "Credentials json string cannot be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(BucketNameTextBox.Text)) {
                CustomDialog.ShowError("Bucket name error", "Bucket name cannot be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(EmailTextBox.Text)) {
                CustomDialog.ShowError("Email error", "Email cannot be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(NameTextBox.Text)) {
                CustomDialog.ShowError("Name error", "Name cannot be empty.");
                return false;
            }

            if (CredentialsCatalog.Credentials.Where(x => x.Email == EmailTextBox.Text).Any()) {
                CustomDialog.ShowError("Email error", "Email already exists.");
                return false;
            }

            return true;
        }
    }
}
