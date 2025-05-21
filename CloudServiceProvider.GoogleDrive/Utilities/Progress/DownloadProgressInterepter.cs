using System;
using Google.Apis.Download;

namespace CloudServiceProvider.GoogleDrive {
    public class DownloadProgressInterepter {
        public IProgress<ByteProgressReport> Progress { get; set; }
        public IMediaDownloader MediaDownloader { get; set; }
        public long Length { get; set; }

        public DownloadProgressInterepter(IProgress<ByteProgressReport> progress, IMediaDownloader mediaDownloader, long length) {
            Progress = progress;
            MediaDownloader = mediaDownloader;
            Length = length;

            MediaDownloader.ProgressChanged += MediaDownloader_ProgressChanged;
        }

        public void Report(IDownloadProgress value) {
            RequestStatus status = RequestStatus.InProgress;

            switch (value.Status) {
                case DownloadStatus.Completed:
                    status = RequestStatus.Successfull;
                    break;
                case DownloadStatus.Failed:
                    status = RequestStatus.OtherError;
                    break;
            }

            Progress.Report(new ByteProgressReport(status, value.BytesDownloaded) { 
                Exception = value.Exception
            });
        }

        private void MediaDownloader_ProgressChanged(IDownloadProgress downloadProgress) {
            Report(downloadProgress);
        }
    }
}
