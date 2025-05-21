using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace CloudServiceProvider.GoogleDrive {
    static class ImageUtilities {
        public static Image DownloadImage(string url) {
            using (WebClient webClient = new WebClient()) {
                using (Stream stream = webClient.OpenRead(url)) {
                    return Image.FromStream(stream);
                }
            }
        }
    }
}
