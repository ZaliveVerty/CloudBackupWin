using System;
using System.Drawing;

namespace CloudServiceProvider.GoogleDrive {
    public class ReauthorizeCommand : ICommand {
        public string DisplayText => "Reauthorize";
        public Image Image => Properties.Resources._16pxUserProfile;

        public UserAccountController UserAccountController { get; set; }
        public TokenCatalog TokenCatalog { get; set; }

        public ReauthorizeCommand(UserAccountController userAccountController, TokenCatalog tokenCatalog) {
            UserAccountController = userAccountController;
            TokenCatalog = tokenCatalog;
        }

        public void Execute() {
            new ReauthorizationEditor(UserAccountController, TokenCatalog).ShowDialog();
        }
    }
}
