using System;
using CommonUtilities;

namespace CloudBackup.Gui {
    public class AppInformation : ObservableResource {
        public DateTime Created {
            get => _created;
            set {
                if (_created == value) return;

                _created = value;
                RaiseOnContentsChanged();
            }
        }
        private DateTime _created;

        public DateTimeHistory KeyChangeHistory {
            get => _keyChangeHistory;
            set {
                if (_keyChangeHistory != null && _keyChangeHistory.Equals(value)) return;

                if (_keyChangeHistory != null) _keyChangeHistory.OnContentsChanged -= Nodes_ContentsChanged;
                _keyChangeHistory = value;
                _keyChangeHistory.OnContentsChanged += Nodes_ContentsChanged;

                RaiseOnContentsChanged();
            }
        }
        private DateTimeHistory _keyChangeHistory;

        public AppInformation() {
            _created = DateTime.Now;
            KeyChangeHistory = new DateTimeHistory(new DateTime[0]);
        }

        private void Nodes_ContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged();
        }
    }
}
