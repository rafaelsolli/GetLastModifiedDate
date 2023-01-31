using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GetLastModifiedDate
{
    public partial class MainForm : Form
    {
        List<string> FileNames { get; set; }

        public MainForm() => InitializeComponent();

        private void FormOpen(object sender, EventArgs e)
        {
            FileNames = Properties.Settings.Default.FileNames ?? new List<string>();
            Width = Properties.Settings.Default.WindowWidth;
            Height = Properties.Settings.Default.WindowHeight;
            ListView.Columns[1].Width = Properties.Settings.Default.FileNameColumnWidth;
            RefreshListView();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FileNames = FileNames;
            Properties.Settings.Default.WindowWidth = Width;
            Properties.Settings.Default.WindowHeight = Height;
            Properties.Settings.Default.FileNameColumnWidth = ListView.Columns[1].Width;
            Properties.Settings.Default.Save();
        }

        private void RefreshListView()
        {
            ListView.Items.Clear();
            FileNames.Sort();
            foreach (var fileName in FileNames)
            {
                var listViewItem = new ListViewItem("");
                listViewItem.SubItems.Add(fileName);
                listViewItem.SubItems.Add(File.Exists(fileName) ? File.GetLastWriteTime(fileName).ToString("dd/MM/yyyy HH:mm") : "File not found");

                ListView.Items.Add(listViewItem);
            }
        }

        private void DoubleClickListViewItem(object sender, EventArgs e)
        {
            var fileName = ListView.SelectedItems[0].SubItems[1].Text;
            if (File.Exists(fileName))
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        Arguments = Path.GetDirectoryName(fileName),
                        FileName = "explorer.exe"
                    }
                };
                process.Start();
            }
        }

        private void AddFile(object sender, EventArgs e)
        {
            if (AddFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in AddFileDialog.FileNames.ToList())
                {
                    if (!FileNames.Contains(fileName)) FileNames.Add(fileName);
                }
            }

            RefreshListView();
        }

        private void RemoveFiles(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in ListView.CheckedItems)
            {
                var fileName = listViewItem.SubItems[1].Text;
                if (FileNames.Contains(fileName)) FileNames.Remove(fileName);
            }

            RefreshListView();
        }

        private void RefreshFilesDates(object sender, EventArgs e) => RefreshListView();
    }
}
