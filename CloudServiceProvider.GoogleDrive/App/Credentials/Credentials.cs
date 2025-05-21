using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class Credentials : ObservableResource {
        public string JsonCredentials {
            get => _jsonCredentials;
            set {
                if (_jsonCredentials == value) return;

                _jsonCredentials = value;
                RaiseOnContentsChanged();
            }
        }
        private string _jsonCredentials;

        public Credentials() {
            _jsonCredentials = string.Empty;
        }
    }
}
