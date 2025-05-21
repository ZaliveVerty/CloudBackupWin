using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class Token : ObservableResource {
        public string JsonToken {
            get => _jsonToken;
            set { 
                if(_jsonToken == value) return;

                _jsonToken = value;
                RaiseOnContentsChanged();
            }
        }
        private string _jsonToken;

        public string Email {
            get => _email;
            set {
                if (_email == value) return;

                _email = value;
                RaiseOnContentsChanged();
            }
        }
        private string _email;

        public DateTime Created {
            get => _created;
            set {
                if (_created == value) return;

                _created = value;
                RaiseOnContentsChanged();
            }
        }
        private DateTime _created;

        public Token() {
            _jsonToken = string.Empty;
            _email = string.Empty;
            _created = DateTime.Now;
        }
    }
}
