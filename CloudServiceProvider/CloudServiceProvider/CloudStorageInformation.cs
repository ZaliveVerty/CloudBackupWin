using System;

namespace CloudServiceProvider {
    public class CloudStorageInformation : ICloudStorageInformation {
        public StorageType StorageType { get; set; }
        public long UsedBytes { get; set; }
        public long Capacity { get; set; }
    }
}
