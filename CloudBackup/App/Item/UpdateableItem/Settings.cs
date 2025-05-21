using System;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class Settings : ObservableResource {
        public IAccount Account {
            get => _account;
            set {
                if (_account == value) return;

                _account = value;
                RaiseOnContentsChanged();
            }
        }
        private IAccount _account;

        public string Password {
            get => _password;
            set {
                if (_password == value) return;

                _password = value;
                RaiseOnContentsChanged();
            }
        }
        private string _password;

        public string PathInDrive {
            get => _pathInDrive;
            set {
                if (_pathInDrive == value) return;

                _pathInDrive = value;
                RaiseOnContentsChanged();
            }
        }
        private string _pathInDrive;

        public string Link {
            get => _link;
            set {
                if (_link == value) return;

                _link = value;
                RaiseOnContentsChanged();
            }
        }
        private string _link;

        public Settings() {
            _password = string.Empty;
            _pathInDrive = string.Empty;
            _link = string.Empty;
        }

        public Settings Clone() {
            return new Settings() {
                Account = Account,
                Password = Password,
                PathInDrive = PathInDrive,
                Link = Link
            };
        }
        public bool Equals(Settings other) {
            return Account == other.Account && Password == other.Password && PathInDrive == other.PathInDrive && Link == other.Link;
        }
    }
}
