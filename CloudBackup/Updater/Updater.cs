using System;
using System.IO;
using System.Text;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class Updater : IUpdater {
        public CloudApplication Application { get; set; }
        
        private static readonly string _temporaryFolder = $"{AppDomain.CurrentDomain.BaseDirectory}\\Storage\\Temporary";
        private static readonly string _usersheetName = "Usersheet.7z";

        public Updater(CloudApplication application) {
            Application = application;
        }

        public bool Update(UpdateableItem updateableItem, IProgress<ProgressReport> progress) {
            ZipProgressAdapter zipProgressAdapter = new ZipProgressAdapter(progress) {
                Title = "Creating archive"
            };

            CompressionResult compressionResult = updateableItem.ProvideFinishedLocalFile(zipProgressAdapter);
            if (!compressionResult.Successfull) return false;

            bool successfull = false;
            try {
                using (FileStream outputStream = File.OpenRead(compressionResult.Output)) {
                    ByteProgressAdapter adapter = new ByteProgressAdapter(progress, outputStream.Length) {
                        Title = "Uploading archive",
                        FinishOnEnd = false
                    };
                    UploadFileRequest uploadFileRequest = new UploadFileRequest() {
                        CloudObjectPath = Path.Combine(updateableItem.Settings.PathInDrive, $"{updateableItem.GeneratedID}{Path.GetExtension(compressionResult.Output)}"),
                        InputStream = outputStream,
                        ShareLink = true,
                        Progress = adapter
                    };

                    CorrectIfMoved(uploadFileRequest.CloudObjectPath, updateableItem);

                    updateableItem.Settings.Account.CloudServiceProvider.CloudProvider.Update(updateableItem.Settings.Account, uploadFileRequest);
                    if (adapter.LastState == State.ExceptionThrown) {
                        progress.Report(ProgressReport.Error);
                    } else {
                        updateableItem.ApplyUpdateMode();

                        updateableItem.Settings.Link = uploadFileRequest.SharedLink;
                        updateableItem.UpdateHistory.Dates.Add(DateTime.Now);

                        Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account).Update(updateableItem, uploadFileRequest);
                        updateableItem.SuspendUpdateMode();

                        UpdateUserSheet(updateableItem, progress);
                        successfull = true;
                    }
                }
            } catch(Exception e) {
                progress.Report(ProgressReport.FromError(e));
            }

            try {
                File.Delete(compressionResult.Output);
            } catch { }

            return successfull;
        }
        public bool UpdateUserSheet(UpdateableItem updateableItem, IProgress<ProgressReport> progress) {
            string usersheetPath = $"{_temporaryFolder}\\{_usersheetName}";
            bool successfull = true;

            try {
                if (File.Exists(usersheetPath)) File.Delete(usersheetPath);
                SheetUtilities.CreateSheet(Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account), usersheetPath, Encoding.UTF8.GetString(Application.Key), Application.CloudSettings.ZipPath);
            } catch {
                successfull = false;
            }

            if (successfull) {
                try {
                    using (FileStream usersheetStream = File.OpenRead(usersheetPath)) {
                        ByteProgressAdapter adapter = new ByteProgressAdapter(progress, usersheetStream.Length) {
                            Title = "Uploading user sheet"
                        };
                        UploadFileRequest uploadFileRequest = new UploadFileRequest() {
                            CloudObjectPath = Path.GetFileName(usersheetPath),
                            InputStream = usersheetStream,
                            ShareLink = true,
                            Progress = adapter
                        };
                        updateableItem.Settings.Account.CloudServiceProvider.CloudProvider.Update(updateableItem.Settings.Account, uploadFileRequest);

                        Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account).Link = uploadFileRequest.SharedLink;
                    }
                } catch {
                    successfull = false;
                }
            }

            File.Delete(usersheetPath);
            
            return successfull;
        }

        public bool Download(UpdateableItem updateableItem, string outputDirectory, IProgress<ProgressReport> progress) {
            string sourcePath = $"{_temporaryFolder}\\{updateableItem.GeneratedID}.7z";

            bool successfull = false;
            try {
                if (File.Exists(sourcePath)) File.Delete(sourcePath);

                ItemInformation info = Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account).ReceiveItemInformation(updateableItem);

                using (FileStream outputStream = File.OpenWrite(sourcePath)) {
                    ByteProgressAdapter adapter = new ByteProgressAdapter(progress, info.LastLength) {
                        Title = "Downloading archive"
                    };
                    DownloadFileRequest downloadFileRequest = new DownloadFileRequest() {
                        CloudObjectPath = info.LastPath,
                        OutputStream = outputStream,
                        Progress = adapter
                    };

                    updateableItem.Settings.Account.CloudServiceProvider.CloudProvider.Download(updateableItem.Settings.Account, downloadFileRequest);
                }

                ZipProgressAdapter unzipAdapter = new ZipProgressAdapter(progress) {
                    Title = "Extracting archive"
                };
                Zip zip = new Zip() {
                    FileName = Application.CloudSettings.ZipPath
                };
                UnzipOperation operation = new UnzipOperation() {
                    ArchivePath = sourcePath,
                    OutputDirectory = outputDirectory,
                    Password = info.LastPassword,
                    Progress = unzipAdapter
                };
                operation.Execute(zip);

                successfull = true;
            } catch {
                progress.Report(ProgressReport.Error);
            }

            try {
                File.Delete(sourcePath);
            } catch { }

            return successfull;
        }

        public bool Delete(UpdateableItem updateableItem) {
            try {
                ObjectRequest objectRequest = new ObjectRequest() {
                    CloudObjectPath = Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account).ReceiveItemInformation(updateableItem).LastPath
                };

                RequestStatus status = updateableItem.Settings.Account.CloudServiceProvider.CloudProvider.Delete(updateableItem.Settings.Account, objectRequest);
                if (status == RequestStatus.Successfull) {
                    updateableItem.Parent.Items.Remove(updateableItem);
                    return true;
                }
            } catch { }

            return false;
        }
        private void CorrectIfMoved(string outputPath, UpdateableItem updateableItem) {
            ItemInformation info = Application.UsersheetCatalog.GetUsersheet(updateableItem.Settings.Account).ReceiveItemInformation(updateableItem);            
            if (info == null || info.LastPath == outputPath) return;

            ObjectRequest objectRequest = new ObjectRequest() {
                CloudObjectPath = info.LastPath
            };

            updateableItem.Settings.Account.CloudServiceProvider.CloudProvider.Delete(updateableItem.Settings.Account, objectRequest);
        }
    }
}
