using System;
using System.Globalization;
using System.Text;
using ClosedXML.Excel;
using CommonUtilities;

namespace CloudRecovery {
    public class ZippedItem : Item {
        public string PathInDrive { get; set; }
        public string Password { get; set; }
        public long Size { get; set; }
        public string Link { get; set; }
        public DateTime LastUpdated { get; set; }

        public string FilePath { get; set; }

        public static ZippedItem FromExcelRow(IXLRow row) {
            try {
                return new ZippedItem() {
                    PathInProgram = row.Cell(2).GetString(),
                    Id = row.Cell(3).GetString(),
                    PathInDrive = row.Cell(4).GetString(),
                    Password = Encoding.UTF8.GetString(Convert.FromBase64String(row.Cell(6).GetString())),
                    Size = long.Parse(row.Cell(8).GetString()),
                    Link = row.Cell(9).GetString(),
                    LastUpdated = DateTime.ParseExact(row.Cell(10).GetString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                };
            } catch {
                return null;
            }
        }
        public void Extract(string outputDirectory, IProgress<float> progress, string zipExeFilePath) {
            Zip zip = new Zip() { 
                FileName = zipExeFilePath
            };

            new UnzipOperation() {
                ArchivePath = FilePath,
                OutputDirectory = outputDirectory,
                Password = Password,
                Progress = progress
            }.Execute(zip);
        }
    }
}
