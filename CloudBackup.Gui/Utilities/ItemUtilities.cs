using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CloudServiceProvider;
using CustomDialogs;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public static class ItemUtilities {
        public static void EditItem(Item item) {
            switch (item) {
                case Group group:
                    RenameItem(group);
                    break;
                case Folder folder:
                    EditFolder(folder);
                    break;
                case FilteredFolder filteredFolder:
                    EditFilteredFolder(filteredFolder);
                    break;
                case ItemBundle itemBundle:
                    EditItemBundle(itemBundle);
                    break;
            }
        }
        public static void EditFolder(Folder folder) {
            new FolderEditor(folder).ShowDialog();
        }
        public static void EditFilteredFolder(FilteredFolder folder) {
            new FilteredFolderEditor(folder).ShowDialog();
        }
        public static void EditItemBundle(ItemBundle itemBundle) {
            new ItemBundleEditor(itemBundle).ShowDialog();
        }
        public static void RenameItem(Item item) {
            InputResult<string> result = CustomDialog.ShowTextInput($"{item.GetTypeString()}'s name", $"Edit the {item.GetTypeString().ToLower()}'s name.",
                item.Name, Properties.Resources._64pxRename, x => NameUtilities.ValidateName(item.GetTypeString(), x));

            if (result.DialogClosed) return;

            item.Name = result.Value;
        }

        public static bool UpdateItems(IList<Item> items, Color progressColor) {
            List<UpdateableItem> updateableItems = new List<UpdateableItem>();
            items.GetUpdateableItems(updateableItems);
            if (updateableItems.Count < 1) return true;

            if (updateableItems.Count == 1) {
                return UpdateUpdateableItem(updateableItems[0], progressColor);
            } else {
                return UpdateManyItems(updateableItems, progressColor);
            }
        }
        public static bool UpdateUpdateableItem(UpdateableItem item, Color progressColor) {
            if (item.Settings.Account == null) {
                CustomDialog.ShowError("Error", "Account has not been selected for the item.");
                return false;
            }

            Progress<ProgressReport> progress = new Progress<ProgressReport>();

            bool successfull = false;
            Thread thread = new Thread(() => {
                successfull = item.Update(progress);
            });
            thread.Start();

            ProgressForm progressForm = new ProgressForm(item.Settings.Account, progress, progressColor);
            progressForm.Icon = ImageToIconConverter.Convert(Properties.Resources._16pxCloudUpload, 16, 16);
            progressForm.SetText("Creating archive");
            progressForm.ShowDialog();

            return successfull;
        }
        public static bool UpdateManyItems(IList<UpdateableItem> items, Color progressColor) {
            ProgressBundleForm progressForm = new ProgressBundleForm(items, progressColor);
            progressForm.ShowDialog();

            return progressForm.UpdateSuccessfull;
        }

        public static void DownloadItem(UpdateableItem item, Color progressColor) {
            if (item.Application.UsersheetCatalog.GetUsersheet(item.Settings.Account)?.ReceiveItemInformation(item) == null) {
                CustomDialog.ShowError("Error", "File has not been uploaded.");
                return;
            }

            InputResult<string> result = CustomDialog.ShowBrowser(BrowseType.BrowseFolder);
            if (result.DialogClosed) return;

            DownloadItem(item, result.Value, progressColor);
        }
        public static void DownloadItem(UpdateableItem item, string path, Color progressColor) {
            Progress<ProgressReport> progress = new Progress<ProgressReport>();

            Thread thread = new Thread(() => {
                item.Download(path, progress);
            });
            thread.Start();

            ProgressForm progressForm = new ProgressForm(item.Settings.Account, progress, progressColor);
            progressForm.Icon = ImageToIconConverter.Convert(Properties.Resources._16pxDownload, 16, 16);
            progressForm.SetText("Downloading");
            progressForm.ShowDialog();
        }

        public static void ChangeUpdateableItemPassword(UpdateableItem item) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(item.Name, item.Settings.Password);
            if (result.DialogClosed) return;

            item.Settings.Password = result.Value;
        }
        public static void ManagerOwner(UpdateableItem item, CloudProviderCatalog cloudProviderCatalog) {
            AccountSelector accountSelector = new AccountSelector(cloudProviderCatalog, item.Settings.Account);
            accountSelector.ShowDialog();

            item.Settings.Account = accountSelector.SelectedAccount;
        }
        public static void SetPath(UpdateableItem item) {
            Func<string, bool> validator = path => {
                if (path.IsValidPath()) return true;

                CustomDialog.ShowError("Error", "Path is invalid.");
                return false;
            };

            InputResult<string> result = CustomDialog.ShowTextInput($"{item.Name} | Path in drive",
                "Edit item's path in drive.", item.Settings.PathInDrive, Properties.Resources._64pxTreeView, validator);
            if (result.DialogClosed) return;

            item.Settings.PathInDrive = result.Value;
        }

        public static void Paste(IEnumerable<Item> items, Group parent) {
            parent.ApplyUpdateMode();

            foreach (var thisItem in items) {
                parent.Items.Add(thisItem.Clone() as Item);
            }

            parent.SuspendUpdateMode();
        }
        public static void Move(IList<Item> items, Group currentGroup) {
            Func<object, bool> validator = thisItem => {
                if (((Item)thisItem).ID != ItemID.Group || items.Contains((Item)thisItem)) return false;
                return true;
            };

            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(currentGroup, new ItemSelectorProfile() {
                SelectedItemValidator = i => !items.Contains(i as Item) && i != currentGroup
            }, validator);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;

            currentGroup.ApplyUpdateMode();
            currentGroup.Move(items, selectionResult.Value[0] as Group);
            currentGroup.SuspendUpdateMode();
        }
        public static void Delete(IList<Item> items, Group parent) {
            if (CustomDialog.ShowDeletionConfirmation()) {
                DeleteGroupContents(parent, items);
            }
        }
        public static bool DeleteGroupContents(Group parent, IList<Item> items) {
            bool errorFree = true;

            for (int i = 0; i < items.Count; i++) {
                Item item = items[i];

                if (item is UpdateableItem updateableItem) {
                    if (updateableItem.Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account)?.ReceiveItemInformation(updateableItem) != null) {
                        if (!updateableItem.Delete()) {
                            errorFree = false;
                        }
                    } else {                        
                        parent.Items.Remove(item);
                    }
                } else {
                    if (DeleteGroupContents(item as Group, (item as Group).Items)) {
                        parent.Items.Remove(item);
                    } else {
                        errorFree = false;
                    }
                }
            }

            return errorFree;
        }

        public static void OpenProperties(Item item, UsersheetCatalog usersheetCatalog) {
            if (item.ID == ItemID.Group) {
                OpenGroupProperties(item as Group, usersheetCatalog);
            } else {
                OpenUpdateableItemProperties(item as UpdateableItem);
            }
        }
        public static void OpenGroupProperties(Group group, UsersheetCatalog usersheetCatalog) {
            new GroupProperties(group, usersheetCatalog).ShowDialog();
        }
        public static void OpenUpdateableItemProperties(UpdateableItem updateableItem) {
            new UpdateableItemProperties(updateableItem, updateableItem.Application.UsersheetCatalog).ShowDialog();
        }

        public static Group ImportItems(CloudApplication application) {
            InputResult<string> pathResult = CustomDialog.ShowBrowser(BrowseType.OpenFile);
            if (pathResult.DialogClosed) return null;

            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(pathResult.Value))) {
                bool encrypted = ms.ReadByte() == 1;

                byte[] input = new byte[ms.Length - 1];
                ms.Read(input, 0, input.Length);

                if (encrypted) {
                    InputResult<byte[]> encryptResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
                    if (encryptResult.DialogClosed) return null;

                    using (MemoryStream decryptedStream = new MemoryStream()) {
                        AesEncryption.Decrypt(new MemoryStream(input), decryptedStream, encryptResult.Value);
                        input = decryptedStream.ToArray();
                    }
                }

                Group group = new ItemDeserializer(application).Deserialize(Tag.FromBytes(input)) as Group;
                group.Name = "Imported group";

                return group;
            }
        }
        public static void ExportItems(CloudApplication application) {
            InputResult<string> pathResult = CustomDialog.ShowBrowser(BrowseType.SaveFile);
            if (pathResult.DialogClosed) return;

            Func<string, bool> keyValidator = key => {
                if (key.Length == 0) return true;
                return KeyExtensions.KeyValidator(key);
            };

            PasswordGeneratorDialogProfile profile = PasswordGeneratorDialogProfile.NewKey;
            profile.Message = "Leave empty if you don't want to encrypt.";
            profile.PasswordValidator = keyValidator;

            InputResult<string> encryptResult = CustomDialog.ShowPasswordGenerator(profile);
            if (encryptResult.DialogClosed) return;

            using (FileStream fileStream = File.Create(pathResult.Value)) {
                fileStream.WriteByte(encryptResult.Value.Length == 0 ? (byte)0 : (byte)1);

                Stream outputStream = encryptResult.Value.Length != 0 ? new MemoryStream() : fileStream;
                new ItemSerializer().Serialize(application.Group).WriteToStream(outputStream);

                if (encryptResult.Value.Length != 0) {
                    using (MemoryStream encryptedStream = new MemoryStream()) {
                        outputStream.Position = 0;
                        AesEncryption.Encrypt(outputStream, fileStream, Encoding.ASCII.GetBytes(encryptResult.Value));
                    }
                }
            }
        }
        public static void DownloadUserSheet(CloudApplication application, IAccount account) {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            if (string.IsNullOrEmpty(folderBrowser.SelectedPath)) return;

            string outputArchive = $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage\\Temporary\\Usersheet.7z";
            using (FileStream fileStream = File.OpenWrite(outputArchive)) {
                DownloadFileRequest fileRequest = new DownloadFileRequest() {
                    CloudObjectPath = Path.GetFileName(outputArchive),
                    OutputStream = fileStream,
                    Progress = new Progress<ByteProgressReport>()
                };

                account.CloudServiceProvider.CloudProvider.Download(account, fileRequest);
            }

            Zip zip = new Zip() {
                FileName = application.CloudSettings.ZipPath,
            };

            UnzipOperation unzipOperation = new UnzipOperation() {
                ArchivePath = outputArchive,
                OutputDirectory = folderBrowser.SelectedPath,
                Password = Encoding.UTF8.GetString(application.Key)
            };

            unzipOperation.Execute(zip);

            File.Delete(outputArchive);

            using (Process process = new Process()) {
                process.StartInfo = new ProcessStartInfo(Path.Combine(folderBrowser.SelectedPath, "UserSheet.xlsx")) {
                    UseShellExecute = true
                };
                process.Start();
            }
        }

        public static void OpenInBrowser(string link) {
            if (string.IsNullOrEmpty(link)) return;

            try {
                using (Process process = new Process()) {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = link;
                    process.Start();
                }
            } catch {
                CustomDialog.ShowError("Error", "There was an error opening the link.");
            }
        }

        public static void ShowInformation(GuiApplication guiApplication) {
            CustomDialog.ShowInformationViewer(new BuildInformationPanel(), new KeyInformationPanel(guiApplication), new ProgramInformationPanel(guiApplication));
        }
        public static void ChangeKey(GuiApplication application) {
            InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator,
                "Current key", "Enter the current key");

            if (keyResult.DialogClosed) return;
            if (!keyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is incorrect.");
                return;
            }

            InputResult<byte[]> newKeyResult = CustomDialog.ShowKeyGenerator();

            if (newKeyResult.DialogClosed) return;
            if (newKeyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is the same.");
                return;
            }

            application.ChangeKey(newKeyResult.Value);

            CustomDialog.ShowMessage("Key changed", "Key changed successfully.", Properties.Resources._16pxKey, SystemSounds.Exclamation);
        }
    }
}
