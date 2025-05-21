using System;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class CloudProvider : ObservableResource {
        public ICloudServiceProvider CloudServiceProvider { get; internal set; }
        public ObservableList<IAccount> Accounts { get; private set; }

        public CloudProvider() {
            Accounts = new ObservableList<IAccount>();
            Accounts.OnItemsAdd += (sender, accounts) => RaiseOnContentsChanged();
            Accounts.OnItemsAdd -= (sender, accounts) => RaiseOnContentsChanged();
        }
    }
}
