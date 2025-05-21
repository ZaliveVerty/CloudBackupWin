using System;
using Google.Apis.Upload;

namespace CloudServiceProvider.GoogleDrive {
    public class UploadProgressIntercepter {
        public IProgress<ByteProgressReport> Progress { get; set; }
        public ResumableUpload ResumableUpload { get; set; }
        public long Length { get; set; }

        public UploadProgressIntercepter(IProgress<ByteProgressReport> progress, ResumableUpload resumableUpload, long length) {
            Progress = progress;
            ResumableUpload = resumableUpload;
            Length = length;

            ResumableUpload.ProgressChanged += ResumableUpload_ProgressChanged;
        }

        public void Report(IUploadProgress value) {
            RequestStatus status = RequestStatus.InProgress;

            switch (value.Status) {
                case UploadStatus.Completed:
                    status = RequestStatus.Successfull;
                    break;
                case UploadStatus.Failed:
                    status = RequestStatus.OtherError;
                    break;
            }

            Progress.Report(new ByteProgressReport(status, value.BytesSent) { 
                Exception = value.Exception
            });
        }

        private void ResumableUpload_ProgressChanged(IUploadProgress uploadProgress) { 
            Report(uploadProgress);
        }
    }
}
