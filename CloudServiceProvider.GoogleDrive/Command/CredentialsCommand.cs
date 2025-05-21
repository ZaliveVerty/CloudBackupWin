using System;
using System.Drawing;

namespace CloudServiceProvider.GoogleDrive {
    public class CredentialsCommand : ICommand {
        public string DisplayText => "Credentials";
        public Image Image => Properties.Resources._16pxCredentials;

        public Credentials Credentials { get; set; }

        public CredentialsCommand(Credentials credentials) {
            Credentials = credentials;
        }

        public void Execute() {
            new CredentialsEditor(Credentials).ShowDialog();
        }
    }
}
