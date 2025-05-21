using System;
using System.Collections.Generic;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class UsersheetCatalog : ObservableResource {
        public ObservableDictionary<string, Usersheet> Usersheets { get; private set; }

        public UsersheetCatalog() {
            Usersheets = new ObservableDictionary<string, Usersheet>();
            Usersheets.OnItemsAdd += (sender, pairs) => {
                foreach (KeyValuePair<string, Usersheet> pair in pairs) {
                    pair.Value.OnContentsChanged += Usersheet_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };
            Usersheets.OnItemsRemove += (sender, pairs) => {
                foreach (KeyValuePair<string, Usersheet> pair in pairs) {
                    pair.Value.OnContentsChanged -= Usersheet_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };
        }

        private void Usersheet_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged();
        }

        public Usersheet GetUsersheet(IAccount account) {
            if (account == null) return null;
            string key = $"{account.Email}\n{account.CloudServiceProvider.Name}";

            if (!Usersheets.TryGetValue(key, out Usersheet usersheet)) {
                usersheet = new Usersheet();

                Usersheets.Add(key, usersheet);
            }

            return usersheet;
        }
    }
}
