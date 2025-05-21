using System;
using System.Collections.Generic;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class CloudProviderCatalog : ObservableResource {
        public ObservableList<CloudProvider> CloudProviders { get; private set; }

        public IAccount SelectedAccount {
            get => _selectedAccount;
            set {
                if (_selectedAccount == value) return;

                _selectedAccount = value;
                RaiseOnContentsChanged();
            }
        }
        private IAccount _selectedAccount;

        internal IList<ICloudServiceProvider> CloudServiceProviders { get; set; }

        public CloudProviderCatalog() { 
            CloudProviders = new ObservableList<CloudProvider>();
            CloudProviders.OnItemsAdd += (sender, providers) => {
                foreach (CloudProvider cloudProvider in providers) {
                    cloudProvider.OnContentsChanged += CloudProvider_OnContentsChanged;
                }
                
                RaiseOnContentsChanged();
            };
            CloudProviders.OnItemsAdd -= (sender, providers) => {
                foreach (CloudProvider cloudProvider in providers) {
                    cloudProvider.OnContentsChanged -= CloudProvider_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };

            CloudServiceProviders = new List<ICloudServiceProvider>();
        }

        private void CloudProvider_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged();
        }

        internal void Load(CloudApplication application) {
            AddCloudProvider(application, new CloudServiceProvider.GoogleDrive.GoogleDriveServiceProvider());
            AddCloudProvider(application, new CloudServiceProvider.GoogleCloud.GoogleCloudServiceProvider());
        }
        private void AddCloudProvider(CloudApplication application, ICloudServiceProvider cloudServiceProvider) {
            NamedStreamProviderController namedSerializeableResource = new NamedStreamProviderController($"Storage\\CloudProviders\\{cloudServiceProvider.Name}", application.Key, application.ResourceController);
            cloudServiceProvider.Initialize(namedSerializeableResource);

            CloudServiceProviders.Add(cloudServiceProvider);
        }

        public CloudProvider GetCloudProvider(string cloudProviderName) {
            foreach (CloudProvider cloudProvider in CloudProviders) {
                if (cloudProvider.CloudServiceProvider.Name == cloudProviderName) return cloudProvider;
            }

            return null;
        }
        public IAccount GetAccount(string email, string cloudProviderName) {
            foreach (CloudProvider cloudProvider in CloudProviders) {
                if (cloudProvider.CloudServiceProvider.Name != cloudProviderName) continue;

                foreach (IAccount account in cloudProvider.Accounts) { 
                    if(account.Email == email) return account;
                }
            }
            
            return null;
        }
    }
}
