using System;
using System.Drawing;
using System.IO;

namespace CloudBackup {
    public static class ImageUtilities {
        public static byte[] ImageToByteArray(Image image) {
            using (MemoryStream stream = new MemoryStream()) {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                return stream.ToArray();
            }
        }
        public static Image ImageFromByteArray(byte[] byteArray) {
            using (MemoryStream stream = new MemoryStream(byteArray)) {
                return Image.FromStream(stream);
            }
        }
    }
}
