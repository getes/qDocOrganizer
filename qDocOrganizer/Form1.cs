namespace qDocOrganizer
{
    public partial class qDocOrganizer : Form
    {
        private List<string> allFiles = new List<string>();

        public qDocOrganizer()
        {
            InitializeComponent();
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
                        allFiles.AddRange(GetAllFilesRecursive(selectedPath));
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

        private IEnumerable<string> GetAllFilesRecursive(string directory)
        {
            foreach (var file in Directory.GetFiles(directory))
            {
                yield return file;
            }
            foreach (var dir in Directory.GetDirectories(directory))
            {
                foreach (var file in GetAllFilesRecursive(dir))
                {
                    yield return file;
                }
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
    }
}
