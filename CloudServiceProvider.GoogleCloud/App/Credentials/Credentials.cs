using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud {
    public class Credentials : ObservableResource {
        public Common.Credentials AccountCredentials {
            get => _accountCredentials;
            set {
                if (_accountCredentials == value) return;

                if (_accountCredentials != null) _accountCredentials.OnContentsChanged -= AccountCredentials_OnContentsChanged;
                _accountCredentials = value;
                _accountCredentials.OnContentsChanged += AccountCredentials_OnContentsChanged;

                RaiseOnContentsChanged();
            }
        }
        private Common.Credentials _accountCredentials;

        public string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                RaiseOnContentsChanged();
            }
        }
        private string _name;

        public string Email {
            get => _email;
            set {
                if (_email == value) return;

                _email = value;
                RaiseOnContentsChanged ();
            }
        }
        private string _email;

        public string FolderName {
            get => _folderName;
            set {
                if (_folderName == value) return;

                _folderName = value;
                RaiseOnContentsChanged();
            }
        }
        private string _folderName;

        public Credentials() { 
            AccountCredentials = new Common.Credentials();
            _name = string.Empty;
            _email = string.Empty;
            _folderName = string.Empty;
        }

        private void AccountCredentials_OnContentsChanged(object sender, EventArgs e) { 
            RaiseOnContentsChanged();
        }
    }
}
