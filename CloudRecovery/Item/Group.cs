using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ClosedXML.Excel;

namespace CloudRecovery {
    public class Group : Item {
        public IList<Item> Items { get; set; }
        public Group Parent { get; set; }

        public Group() {
            Items = new List<Item>();
        }

        public static Group FromDirectory(string directoryPath) {
            using (XLWorkbook book = new XLWorkbook($"{directoryPath}\\Usersheet.xlsx")) {
                IXLWorksheet sheet = book.Worksheet("Data");

                IXLRow[] rows = sheet.Rows().ToArray();
                List<ZippedItem> zippedItems = new List<ZippedItem>(rows.Length - 1);
                
                for (int i = 1; i < rows.Length; i++) {
                    ZippedItem item = ZippedItem.FromExcelRow(rows[i]);
                    if(item != null) zippedItems.Add(item);
                }

                string[] files = Directory.GetFiles(directoryPath, "*.7z", SearchOption.AllDirectories);
                Dictionary<string, string> paths = files.ToDictionary(x => Path.GetFileName(x));

                List<ZippedItem> remove = new List<ZippedItem>();
                foreach (var zippedItem in zippedItems) {
                    if (paths.TryGetValue(zippedItem.Id, out string path)) {
                        zippedItem.FilePath = path;
                    } else {
                        remove.Add(zippedItem);
                    }
                }
                zippedItems.RemoveAll(x => remove.Contains(x));

                Dictionary<string, Group> groups = new Dictionary<string, Group>();
                foreach (var zippedItem in zippedItems) {
                    string parent = Path.GetDirectoryName(zippedItem.PathInProgram);

                    if (!groups.TryGetValue(parent, out Group group)) {
                        group = new Group() {
                            PathInProgram = parent
                        };
                        groups.Add(group.PathInProgram, group);
                    }

                    group.Items.Add(zippedItem);
                }

                return CreateRoot(groups);
            }
        }
        public static Group FromUsersheet(string usersheet) {
            using (XLWorkbook book = new XLWorkbook(usersheet)) {
                IXLWorksheet sheet = book.Worksheet("Data");

                IXLRow[] rows = sheet.Rows().ToArray();
                List<ZippedItem> zippedItems = new List<ZippedItem>(rows.Length - 1);

                for (int i = 1; i < rows.Length; i++) {
                    ZippedItem item = ZippedItem.FromExcelRow(rows[i]);
                    if (item != null) zippedItems.Add(item);
                }

                Dictionary<string, Group> groups = new Dictionary<string, Group>();
                foreach (ZippedItem item in zippedItems) {
                    string parentName = Path.GetDirectoryName(item.PathInProgram);

                    if (!groups.TryGetValue(parentName, out Group parent)) {
                        parent = new Group() { 
                            PathInProgram = parentName,
                            Id = Path.GetDirectoryName(item.PathInDrive)
                        };

                        groups.Add(parentName, parent);
                    }

                    parent.Items.Add(item);
                }

                return CreateRoot(groups);
            }
        }

        private static Group CreateRoot(IDictionary<string, Group> groups) {
            Dictionary<string, Group> clone = new Dictionary<string, Group>(groups);

            foreach (var pair in groups) {
                FindParent(pair.Value, clone);
            }

            Group root = new Group() { 
                PathInProgram = "Home"
            };

            foreach (var pair in clone) {
                if (pair.Value.Parent == null) {
                    root.Items.Add(pair.Value);
                    pair.Value.Parent = root;
                }
            }
            
            return root;
        }
        private static void FindParent(Group group, IDictionary<string, Group> groups) {
            string parentPath = Path.GetDirectoryName(group.PathInProgram);
            if (string.IsNullOrEmpty(parentPath)) return;

            if (!groups.TryGetValue(parentPath, out Group parent)) {
                parent = new Group() {
                    PathInProgram = Path.GetDirectoryName(group.PathInProgram)
                };

                groups.Add(parent.PathInProgram, parent);
                FindParent(parent, groups);
            }

            group.Parent = parent;
            parent.Items.Insert(0, group);
        }
    }
}
