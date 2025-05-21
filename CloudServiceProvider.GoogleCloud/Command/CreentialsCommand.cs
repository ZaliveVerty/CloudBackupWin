using System;
using System.Drawing;

namespace CloudServiceProvider.GoogleCloud {
    public class CreentialsCommand : ICommand {
        public string DisplayText => "Edit credentials";
        public Image Image => Properties.Resources._16pxCredentials;

        public CredentialsCatalog CredentialsCatalog { get; set; }

        public CreentialsCommand(CredentialsCatalog credentialsCatalog) { 
            CredentialsCatalog = credentialsCatalog;
        }

        public void Execute() {
            new CredentialsCatalogEditor(CredentialsCatalog).ShowDialog();
        }
    }
}
