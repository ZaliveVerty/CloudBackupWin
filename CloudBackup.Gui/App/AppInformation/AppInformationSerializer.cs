using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class AppInformationSerializer : IObjectSerializer<AppInformation> {
        public Tag Serialize(AppInformation item) {
            return new ObjectTag() {
                { "KeyChangeHistory", item.KeyChangeHistory.Dates.ToArray() },
                { "Created", item.Created }
            };
        }
    }
}
