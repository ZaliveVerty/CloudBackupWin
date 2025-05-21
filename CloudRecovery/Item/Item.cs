using System;
using System.IO;

namespace CloudRecovery {
    public abstract class Item {
        public string DisplayName {
            get { 
                string directoryName = Path.GetFileName(PathInProgram);
                
                if (string.IsNullOrWhiteSpace(directoryName)) return PathInProgram;
                return directoryName;
            }
        }
        public string PathInProgram { get; set; }
        public string Id { get; set; }
    }
}
