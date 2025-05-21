using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleDrive {
    public partial class CredentialsEditor : Form {
        public Credentials Credentials { get; set; }

        public CredentialsEditor(Credentials credentials) {
            InitializeComponent();

            Credentials = credentials;
            Icon = ImageToIconConverter.Convert(Properties.Resources._16pxCredentials, 64, 64);

            RichTextBox.Text = Credentials.JsonCredentials;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
        private void SaveButton_Click(object sender, EventArgs e) {
            Credentials.JsonCredentials = RichTextBox.Text;
            Close();
        }
    }
}
