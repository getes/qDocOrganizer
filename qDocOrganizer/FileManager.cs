using System.Diagnostics;

namespace qDocOrganizer
{
    public class FileManager
    {
        public static IEnumerable<string> GetAllFilesRecursive(string directory)
        {
            if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory))
                throw new ArgumentException("Invalid directory path.", nameof(directory));

            return Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories);
        }

        public static void OpenFileWithDefaultApp(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new ArgumentException("Invalid file path.", nameof(filePath));

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        public static bool MoveFile(List<ListViewItem> itemsToRemove, ListViewItem item, string sourceFile, string fileName, string destFile)
        {
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
                            return false;
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

            return true;
        }

        public static void RemoveFiles(List<ListViewItem> itemsToRemove)
        {
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
        }

        public static void CopyFilesTo(string destinationPath)
        {
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
