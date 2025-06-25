namespace qDocOrganizer
{
    public partial class qDocOrganizer : Form
    {
        private List<string> allFiles = new List<string>();

        public qDocOrganizer()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Detect Ctrl + A
            if (keyData == (Keys.Control | Keys.A))
            {
                if (lstView_files.Focused || lstView_files.ContainsFocus)
                {
                    foreach (ListViewItem item in lstView_files.Items)
                    {
                        item.Selected = true;
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bt_ofd_Click(object sender, EventArgs e)
        {
            folderBrowser.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                allFiles.Clear();
                string selectedPath = folderBrowser.SelectedPath;
                if (!string.IsNullOrEmpty(selectedPath) && Directory.Exists(selectedPath))
                {
                    lb_ofdPath.Text = selectedPath;
                    if (chkb_recursive.Checked)
                    {
                        allFiles.AddRange(FileManager.GetAllFilesRecursive(selectedPath));
                    }   
                    else
                    {
                        allFiles.AddRange(Directory.GetFiles(selectedPath));
                    }

                    // Extract all unique file extensions from the files list
                    var extensions = allFiles
                        .Select(f => Path.GetExtension(f)?.ToLowerInvariant())
                        .Where(ext => !string.IsNullOrEmpty(ext))
                        .Distinct()
                        .ToList();

                    // Populate the combo box with the unique extensions
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("All Files");
                    foreach (var ext in extensions)
                    {
                        if (!string.IsNullOrEmpty(ext))
                            comboBox1.Items.Add(ext);
                    }

                    PopulateListView();
                    comboBox1.Refresh();
                }
            }
        }

        private void PopulateListView(string selectedExtension = null)
        {
            // List all files in the ListView with two columns
            lstView_files.Items.Clear();
            foreach (var file in allFiles)
            {
                if (selectedExtension == null)
                {
                    // If no extension is selected, add all files
                }
                else if (Path.GetExtension(file)?.ToLowerInvariant() != selectedExtension)
                {
                    continue; // Skip files that do not match the selected extension
                }

                var fileName = Path.GetFileName(file);
                var item = new ListViewItem(fileName);
                item.SubItems.Add(file);
                lstView_files.Items.Add(item);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedExtension = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedExtension) || selectedExtension == "All Files")
            {
                PopulateListView();
            }
            else
            {
                PopulateListView(selectedExtension);
            }
        }

        private void MoveTo_Click(object sender, EventArgs e)
        {
            if (lstView_files.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one or more files to move.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the destination folder";
                folderDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = folderDialog.SelectedPath;
                    var itemsToRemove = new List<ListViewItem>();

                    foreach (ListViewItem item in lstView_files.SelectedItems)
                    {
                        string sourceFile = item.SubItems[1].Text;
                        string fileName = Path.GetFileName(sourceFile);
                        string destFile = Path.Combine(destinationPath, fileName);

                        try
                        {
                            if (File.Exists(sourceFile))
                            {
                                // If file with same name exists at destination, prompt for overwrite
                                if (File.Exists(destFile))
                                {
                                    var result = MessageBox.Show(
                                        $"File '{fileName}' already exists in the destination. Overwrite?",
                                        "File Exists",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                                    if (result != DialogResult.Yes)
                                        continue;
                                }

                                File.Move(sourceFile, destFile, true);
                                allFiles.Remove(sourceFile);
                                itemsToRemove.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to move file: {sourceFile}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    foreach (var item in itemsToRemove)
                    {
                        lstView_files.Items.Remove(item);
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstView_files.SelectedItems.Count == 0)
                return;

            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem item in lstView_files.SelectedItems)
            {
                string filePath = item.SubItems[1].Text;
                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    allFiles.Remove(filePath);
                    itemsToRemove.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete file: {filePath}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var item in itemsToRemove)
            {
                lstView_files.Items.Remove(item);
            }
        }

        private void copyToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstView_files.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one or more files to copy.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the destination folder";
                folderDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = folderDialog.SelectedPath;

                    foreach (ListViewItem item in lstView_files.SelectedItems)
                    {
                        string sourceFile = item.SubItems[1].Text;
                        string fileName = Path.GetFileName(sourceFile);
                        string destFile = Path.Combine(destinationPath, fileName);

                        try
                        {
                            if (File.Exists(sourceFile))
                            {
                                // If file with same name exists at destination, prompt for overwrite
                                if (File.Exists(destFile))
                                {
                                    var result = MessageBox.Show(
                                        $"File '{fileName}' already exists in the destination. Overwrite?",
                                        "File Exists",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                                    if (result != DialogResult.Yes)
                                        continue;
                                }

                                File.Copy(sourceFile, destFile, true);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to copy file: {sourceFile}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void toolStripThemeDark_Click(object sender, EventArgs e)
        {
            SetDarkTheme();
        }

        private void toolStripDefaultTheme_Click(object sender, EventArgs e)
        {
            setDefaultTheme();
        }

        private void SetDarkTheme()
        {
            // Set dark theme colors for controls
            this.BackColor = Color.FromArgb(30, 30, 30);
            lstView_files.BackColor = Color.FromArgb(40, 40, 40);
            lstView_files.ForeColor = Color.White;
            folderBrowser.Description = "Select a folder to organize";
            lb_ofdPath.ForeColor = Color.White;
            comboBox1.BackColor = Color.FromArgb(40, 40, 40);
            comboBox1.ForeColor = Color.White;
            bt_ofd.BackColor = Color.FromArgb(50, 50, 50);
            bt_ofd.ForeColor = Color.White;
            lb_extFilter.ForeColor = Color.White;
            chkb_recursive.ForeColor = Color.White;
        }

        private void setDefaultTheme()
        {
            // Set default theme colors for controls
            this.BackColor = SystemColors.Control;
            lstView_files.BackColor = SystemColors.Window;
            lstView_files.ForeColor = SystemColors.ControlText;
            folderBrowser.Description = "Select a folder to organize";
            lb_ofdPath.ForeColor = SystemColors.ControlText;
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.ForeColor = SystemColors.ControlText;
            bt_ofd.BackColor = SystemColors.ButtonFace;
            bt_ofd.ForeColor = SystemColors.ControlText;
            lb_extFilter.ForeColor = SystemColors.ControlText;
            chkb_recursive.ForeColor = SystemColors.ControlText;

        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            string aboutText = "qDocOrganizer\n\nVersión 1.0\n\nDeveloped by QaSaR.\n\n© 2025";
            MessageBox.Show(aboutText, "Acerca de qDocOrganizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void OpenSelectedFiles(object sender, EventArgs e)
        {
            if (lstView_files.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstView_files.SelectedItems)
                {
                    string filePath = item.SubItems[1].Text;
                    FileManager.OpenFileWithDefaultApp(filePath);
                }
            }
        }
    }
}
