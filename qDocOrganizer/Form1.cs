namespace qDocOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void bt_ofd_Click(object sender, EventArgs e)
        //{
        //    folderBrowser.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    if (folderBrowser.ShowDialog() == DialogResult.OK)
        //    {
        //        List<string> files = new List<string>();
        //        string selectedPath = folderBrowser.SelectedPath;
        //        if (!string.IsNullOrEmpty(selectedPath) && Directory.Exists(selectedPath))
        //        {
        //            lb_ofdPath.Text = selectedPath;
        //            if (chkb_recursive.Checked)
        //            {
        //                files.AddRange(GetAllFilesRecursive(selectedPath));
        //            }
        //            else
        //            {
        //                files.AddRange(Directory.GetFiles(selectedPath));
        //            }

        //            // Extract all unique file extensions from the files list
        //            var extensions = files
        //                .Select(f => Path.GetExtension(f)?.ToLowerInvariant())
        //                .Where(ext => !string.IsNullOrEmpty(ext))
        //                .Distinct()
        //                .ToList();

        //            // Populate the combo box with the unique extensions
        //            comboBox1.Items.Clear();
        //            comboBox1.Items.Add("All Files");
        //            foreach (var ext in extensions)
        //            {
        //                comboBox1.Items.Add(ext);
        //            }

        //            //list all files in the listbox
        //            lstbox_files.Items.Clear();
        //            foreach (var file in files)
        //            {
        //                lstbox_files.Items.Add(file);
        //            }
        //        }
        //    }
        //}

        private List<string> allFiles = new List<string>();

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
                        comboBox1.Items.Add(ext);
                    }

                    //list all files in the listbox
                    lstbox_files.Items.Clear();
                    foreach (var file in allFiles)
                    {
                        lstbox_files.Items.Add(file);
                    }
                }
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
            lstbox_files.Items.Clear();

            if (string.IsNullOrEmpty(selectedExtension) || selectedExtension == "All Files")
            {
                foreach (var file in allFiles)
                {
                    lstbox_files.Items.Add(file);
                }
            }
            else
            {
                foreach (var file in allFiles)
                {
                    if (Path.GetExtension(file)?.ToLowerInvariant() == selectedExtension)
                    {
                        lstbox_files.Items.Add(file);
                    }
                }
            }
        }
    }
}
