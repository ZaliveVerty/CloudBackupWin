using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsCatalog : ObservableResource {
        public ObservableList<Credentials> Credentials { get; private set; }

        public CredentialsCatalog() { 
            Credentials = new ObservableList<Credentials>();
            Credentials.OnItemsAdd += (sender, credentials) => {
                foreach (Credentials credential in credentials) {
                    credential.OnContentsChanged += Credentials_OnContentsChanged;
                }
                
                RaiseOnContentsChanged();
            };
            Credentials.OnItemsRemove += (sender, credentials) => {
                foreach (Credentials credential in credentials) {
                    credential.OnContentsChanged -= Credentials_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };
        }

        private void Credentials_OnContentsChanged(object sender, EventArgs e) { 
            RaiseOnContentsChanged();
        }
    }
}
