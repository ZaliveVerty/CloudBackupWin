using System;
using System.Threading;
using CustomDialogs;

namespace CloudRecovery.Gui {
    public static class ItemUtilities {
        public static void Extract(ZippedItem item, string filePath, Settings settings) {
            try {
                Progress<float> progress = new Progress<float>();

                new Thread(() => {
                    string temp = item.FilePath;
                    item.FilePath = filePath;

                    item.Extract(settings.LastDirectory, progress, settings.ZipPath);
                    item.FilePath = temp;
                    
                    ((IProgress<float>)progress).Report(1);
                }).Start();

                ProgressForm form = new ProgressForm(progress);
                form.SetText("Extracting");
                form.ShowDialog();
            } catch (Exception e) {
                CustomDialog.ShowError(e);
            }
        }
    }
}
