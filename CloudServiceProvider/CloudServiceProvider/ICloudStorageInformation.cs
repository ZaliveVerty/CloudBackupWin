using System;

namespace CloudServiceProvider {
    public interface ICloudStorageInformation {
        StorageType StorageType { get; }

        long UsedBytes { get; }
        long Capacity { get; }
    }
}
