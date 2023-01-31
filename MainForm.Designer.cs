
namespace GetLastModifiedDate
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.RemoveFilesButton = new System.Windows.Forms.Button();
            this.RefreshFilesDatesButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.CheckBoxColumn = new System.Windows.Forms.ColumnHeader();
            this.FileNameColumn = new System.Windows.Forms.ColumnHeader();
            this.LastModifiedDateColumn = new System.Windows.Forms.ColumnHeader();
            this.AddFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.ColumnCount = 4;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TablePanel.Controls.Add(this.AddFileButton, 1, 1);
            this.TablePanel.Controls.Add(this.RemoveFilesButton, 2, 1);
            this.TablePanel.Controls.Add(this.RefreshFilesDatesButton, 3, 1);
            this.TablePanel.Controls.Add(this.ListView, 0, 0);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TablePanel.Size = new System.Drawing.Size(584, 261);
            this.TablePanel.TabIndex = 0;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFileButton.Location = new System.Drawing.Point(209, 228);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(120, 30);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add file";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFile);
            // 
            // RemoveFilesButton
            // 
            this.RemoveFilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveFilesButton.Location = new System.Drawing.Point(335, 228);
            this.RemoveFilesButton.Name = "RemoveFilesButton";
            this.RemoveFilesButton.Size = new System.Drawing.Size(120, 30);
            this.RemoveFilesButton.TabIndex = 3;
            this.RemoveFilesButton.Text = "Remove files";
            this.RemoveFilesButton.UseVisualStyleBackColor = true;
            this.RemoveFilesButton.Click += new System.EventHandler(this.RemoveFiles);
            // 
            // RefreshFilesDatesButton
            // 
            this.RefreshFilesDatesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshFilesDatesButton.Location = new System.Drawing.Point(461, 228);
            this.RefreshFilesDatesButton.Name = "RefreshFilesDatesButton";
            this.RefreshFilesDatesButton.Size = new System.Drawing.Size(120, 30);
            this.RefreshFilesDatesButton.TabIndex = 4;
            this.RefreshFilesDatesButton.Text = "Refresh files\' dates";
            this.RefreshFilesDatesButton.UseVisualStyleBackColor = true;
            this.RefreshFilesDatesButton.Click += new System.EventHandler(this.RefreshFilesDates);
            // 
            // ListView
            // 
            this.ListView.CheckBoxes = true;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckBoxColumn,
            this.FileNameColumn,
            this.LastModifiedDateColumn});
            this.TablePanel.SetColumnSpan(this.ListView, 4);
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(3, 3);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(578, 219);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.DoubleClick += new System.EventHandler(this.DoubleClickListViewItem);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.Text = "#";
            this.CheckBoxColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckBoxColumn.Width = 20;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.Text = "File name";
            this.FileNameColumn.Width = 400;
            // 
            // LastModifiedDateColumn
            // 
            this.LastModifiedDateColumn.Text = "Last modified date";
            this.LastModifiedDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastModifiedDateColumn.Width = 150;
            // 
            // AddFileDialog
            // 
            this.AddFileDialog.Filter = "All files|*.*";
            this.AddFileDialog.Multiselect = true;
            this.AddFileDialog.Title = "Add file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.TablePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get last modified date";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.FormOpen);
            this.TablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button RemoveFilesButton;
        private System.Windows.Forms.Button RefreshFilesDatesButton;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader FileNameColumn;
        private System.Windows.Forms.ColumnHeader LastModifiedDateColumn;
        private System.Windows.Forms.ColumnHeader CheckBoxColumn;
        private System.Windows.Forms.OpenFileDialog AddFileDialog;
    }
}

