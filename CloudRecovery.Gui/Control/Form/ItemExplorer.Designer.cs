
namespace CloudRecovery.Gui {
    partial class ItemExplorer {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            CustomDialogs.CustomToolStripRenderer customToolStripRenderer1 = new CustomDialogs.CustomToolStripRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.ExtractMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractWithOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPasswordSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.Change7ZipPathMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInBrowserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            customToolStripRenderer1.RoundedEdges = true;
            this.MenuStrip.CustomRenderer = customToolStripRenderer1;
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInBrowserMenuItem,
            this.ExtractMenuItem,
            this.ExtractWithOptionsMenuItem,
            this.ShowPasswordMenuItem,
            this.ShowPasswordSeperator,
            this.Change7ZipPathMenuitem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(181, 142);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // ExtractMenuItem
            // 
            this.ExtractMenuItem.Name = "ExtractMenuItem";
            this.ExtractMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExtractMenuItem.Text = "Extract";
            this.ExtractMenuItem.Click += new System.EventHandler(this.ExtractMenuItem_Click);
            // 
            // ExtractWithOptionsMenuItem
            // 
            this.ExtractWithOptionsMenuItem.Name = "ExtractWithOptionsMenuItem";
            this.ExtractWithOptionsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExtractWithOptionsMenuItem.Text = "Extract with options";
            this.ExtractWithOptionsMenuItem.Click += new System.EventHandler(this.ExtractWithOptionsMenuItem_Click);
            // 
            // ShowPasswordMenuItem
            // 
            this.ShowPasswordMenuItem.Image = global::CloudRecovery.Gui.Properties.Resources._16pxKey;
            this.ShowPasswordMenuItem.Name = "ShowPasswordMenuItem";
            this.ShowPasswordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowPasswordMenuItem.Text = "Show password";
            this.ShowPasswordMenuItem.Click += new System.EventHandler(this.ShowPasswordMenuItem_Click);
            // 
            // ShowPasswordSeperator
            // 
            this.ShowPasswordSeperator.Name = "ShowPasswordSeperator";
            this.ShowPasswordSeperator.Size = new System.Drawing.Size(177, 6);
            // 
            // Change7ZipPathMenuitem
            // 
            this.Change7ZipPathMenuitem.Name = "Change7ZipPathMenuitem";
            this.Change7ZipPathMenuitem.Size = new System.Drawing.Size(180, 22);
            this.Change7ZipPathMenuitem.Text = "Change 7zip path";
            this.Change7ZipPathMenuitem.Click += new System.EventHandler(this.Change7ZipPathMenuitem_Click);
            // 
            // OpenInBrowserMenuItem
            // 
            this.OpenInBrowserMenuItem.Name = "OpenInBrowserMenuItem";
            this.OpenInBrowserMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenInBrowserMenuItem.Text = "Open in browser";
            this.OpenInBrowserMenuItem.Click += new System.EventHandler(this.OpenInBrowserMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Recovery";
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragEnter);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExtractMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPasswordMenuItem;
        private System.Windows.Forms.ToolStripSeparator ShowPasswordSeperator;
        private System.Windows.Forms.ToolStripMenuItem Change7ZipPathMenuitem;
        private System.Windows.Forms.ToolStripMenuItem ExtractWithOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInBrowserMenuItem;
    }
}

