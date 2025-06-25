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
    }
}
