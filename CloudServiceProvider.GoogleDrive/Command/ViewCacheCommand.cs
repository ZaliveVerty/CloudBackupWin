using System;
using System.Drawing;

namespace CloudServiceProvider.GoogleDrive {
    public class ViewCacheCommand : ICommand {
        public string DisplayText { get; set; }
        public Image Image => Properties.Resources._16pxCache;

        public IdCacheCatalog IdCacheCatalog { get; set; }

        public ViewCacheCommand(IdCacheCatalog idCacheCatalog, string headerText) {
            DisplayText = headerText;
            IdCacheCatalog = idCacheCatalog;
        }

        public void Execute() {
            new IdResourceEditor(IdCacheCatalog).ShowDialog();
        }
    }
}
