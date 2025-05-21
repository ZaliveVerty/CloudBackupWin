using System;

namespace CloudServiceProvider {
    public interface ICloudProvider {
        void Update(IAccount account, UploadFileRequest uploadFileRequest);
        void Download(IAccount account, DownloadFileRequest downloadFileRequest);
        RequestStatus Delete(IAccount account, ObjectRequest objectRequest);
    }
}
