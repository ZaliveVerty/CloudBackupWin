using System;
using System.IO;
using System.Drawing;

namespace CloudBackup.Gui {
    public class ProgramInformationPanel : CustomDialogs.ProgramInformationPanel {
        public override string HeaderText { get; set; } = "Cloud Provider";
        public override Image Icon { get; set; } = Properties.Resources._64pxGroup;

        public override string ProgramName { get; set; } = "Provider";

        public ProgramInformationPanel(GuiApplication application) {
            ProgramCreated = application.AppInformation.Created.ToString();
            ProgramLocatedIn = Path.GetDirectoryName(BuildInformationPanel.Assembly.Location);
        }
    }
}
