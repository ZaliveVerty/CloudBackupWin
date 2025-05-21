using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using CustomDialogs;
using CommonUtilities;

namespace CloudRecovery.Gui {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0) {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();

                args = new string[] { dialog.SelectedPath };
            }

            string zipPath = "7z.exe";

            try {
                Group group;

                if (Path.GetExtension(args[0]).ToLower() == ".xlsx") {
                    group = Group.FromUsersheet(args[0]);
                } else {
                    string userSheetPath = $"{args[0]}\\Usersheet.xlsx";

                    if (!File.Exists(userSheetPath)) {
                        InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
                        if (keyResult.DialogClosed) return;

                        InputResult<string> zipResult = CustomDialog.ShowTextInput("7zip path", "7zip path", "7z.exe");
                        if (zipResult.DialogClosed) return;

                        zipPath = zipResult.Value;

                        Zip zip = new Zip() {
                            FileName = zipPath
                        };
                        UnzipOperation operation = new UnzipOperation() {
                            ArchivePath = $"{args[0]}\\Usersheet.7z",
                            OutputDirectory = args[0],
                            Password = Encoding.UTF8.GetString(keyResult.Value)
                        };

                        operation.Execute(zip);
                    }

                    group = Group.FromDirectory(args[0]);
                }

                Application.Run(new ItemExplorer(group) { 
                    Settings = new Settings() { 
                        ZipPath = zipPath
                    }
                });
            } catch(Exception e) {
                CustomDialog.ShowError(e);
            }
        }
    }
}
