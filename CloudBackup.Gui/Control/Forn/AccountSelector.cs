using System;
using System.Windows.Forms;
using System.Media;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class AccountSelector : Form {
        public CloudProviderCatalog Providers { get; set; }

        public CloudProvider SelectedProvider { get; private set; }
        public IAccount SelectedAccount { get; private set; }

        private ClickablePanelContainer _cloudContainer;
        private ClickablePanelContainer _accountContainer;

        public bool DialogClosed { get; set; } = true;

        public AccountSelector(CloudProviderCatalog providers, IAccount selectedAccount = null) {
            InitializeComponent();

            Providers = providers;
            SelectedAccount = selectedAccount;

            if (SelectedAccount != null) {
                SelectedProvider = Providers.GetCloudProvider(SelectedAccount.CloudServiceProvider.Name);
            }

            _cloudContainer = GetCloudContainer(Providers);
            _cloudContainer.PanelClick += CloudPanelClick;

            HeaderContainer.Controls.Add(_cloudContainer, 0, 1);

            DisplayPanel();
        }

        private static ClickablePanelContainer GetCloudContainer(CloudProviderCatalog providers) {
            CloudProviderPanel[] panels = new CloudProviderPanel[providers.CloudProviders.Count];
            for (int i = 0; i < panels.Length; i++) {
                panels[i] = new CloudProviderPanel(providers.CloudProviders[i]) { 
                    Margin = new Padding(0)
                };
            }

            return new ClickablePanelContainer(panels) {
                Dock = DockStyle.Top
            };
        }
        private static ClickablePanelContainer GetAccountContainer(CloudProvider service) {
            AccountPanel[] panels = new AccountPanel[service.Accounts.Count];
            for (int i = 0; i < panels.Length; i++) {
                panels[i] = new AccountPanel(service.Accounts[i]) { 
                    Margin = new Padding(0)
                };
            }

            return new ClickablePanelContainer(panels) { 
                Dock = DockStyle.Top,
                Margin = new Padding(0, 0, 0, 10)
            };
        }

        private void DisplayPanel() {
            AddAccountButton.Visible = SelectedProvider != null;
            RemoveAccountButton.Visible = SelectedAccount != null;

            if (SelectedProvider == null) return;

            if (SelectedAccount == null) {
                _accountContainer.Deselect();
                return;
            }

            foreach (var panel in _cloudContainer.CustomPanels) {
                if (((CloudProviderPanel)panel).CloudProvider == SelectedProvider) {
                    _cloudContainer.SelectPanel(panel);
                    SetAccountContainer();

                    return;
                }
            }
        }

        //Cloud panel
        private void CloudPanelClick(object sender, EventArgs e) {
            SelectedProvider = ((CloudProviderPanel)sender).CloudProvider;
            _cloudContainer.SelectPanel((CloudProviderPanel)sender);

            AddAccountButton.Visible = true;
            SetAccountContainer();
        }

        //Accounts panel
        private void SetAccountContainer() {
            _accountContainer = GetAccountContainer(SelectedProvider);

            AccountContainer.Controls.Remove(AccountContainer.GetControlFromPosition(0, 0));

            if (_accountContainer.CustomPanels.Count < 1) {
                RemoveAccountButton.Visible = false;
                return;
            }
            AccountContainer.Controls.Add(_accountContainer, 0, 0);

            bool panelSelected = false;
            foreach (var panel in _accountContainer.CustomPanels) {
                if (((AccountPanel)panel).Account == SelectedAccount) {
                    _accountContainer.SelectPanel(panel);
                    panelSelected = true;
                    break;
                }
            }
            RemoveAccountButton.Visible = panelSelected;

            _accountContainer.PanelClick += AccountPanelClick;
        }
        private void AccountPanelClick(object sender, EventArgs e) {
            _accountContainer.SelectPanel((ClickablePanel)sender);
            SelectedAccount = ((AccountPanel)sender).Account;
        }

        //Bottom buttons
        private void AddAccountButton_Click(object sender, EventArgs e) {
            var control = AccountContainer.GetControlFromPosition(0, 1);
            if (control == null) return;

            try {
                IAccount account = SelectedProvider.CloudServiceProvider.CreateAccount();
                if (account == null) return;

                SelectedProvider.Accounts.Add(account);

                DisplayPanel();
            } catch (Exception exception) {
                CustomDialog.ShowError(exception);
            }
        }
        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }

        private void DeselectButton_Click(object sender, EventArgs e) {
            SelectedAccount = null;

            DisplayPanel();
        }
        private void RemoveAccountButton_Click(object sender, EventArgs e) {
            Providers.ApplyUpdateMode();
            RemoveAccount();
            Providers.SuspendUpdateMode();
        }

        private void RemoveAccount() {
            string result = CustomDialog.ShowMessage("Remove account", "Are you sure you want to remove this account?",
                Properties.Resources._64pxTrash, SystemSounds.Hand, "Remove", "No");

            if (result == "No" || result == "Closed") return;
            if (!SelectedAccount.CloudServiceProvider.RemoveAccount(SelectedAccount)) return;

            if (Providers.SelectedAccount == SelectedAccount) Providers.SelectedAccount = null;

            int index = SelectedProvider.Accounts.IndexOf(SelectedAccount);
            if (index > -1) {
                SelectedProvider.Accounts.RemoveAt(index);
            }

            SelectedAccount = null;

            CustomDialog.ShowMessage("Reset", "The application must be reset.", Properties.Resources._16pxInformation, SystemSounds.Hand);
        }
    }
}
