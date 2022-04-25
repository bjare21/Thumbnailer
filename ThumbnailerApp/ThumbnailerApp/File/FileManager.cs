namespace File
{
    public static class FileManager
    {
        private static readonly string[] defaultFilesTypes = {
            "jpg",
            "png",
            "bmp",
            "gif" };
        public static IEnumerable<string> LoadFromDirectory(string directoryPath)
        {
            IEnumerable<string> files = new List<string>();

            if (!isValidPath(directoryPath)) return files;

            files = Directory.EnumerateFiles(directoryPath, ".")
                .Where(file =>
                defaultFilesTypes.Contains(file.ToLower()[^3..]));

            return files;
        }
        public static IEnumerable<string> LoadFromDirectory(string directoryPath, string fileType)
        {
            IEnumerable<string> files = new List<string>();

            if (!isValidPath(directoryPath)) return files;

            files = Directory.EnumerateFiles(directoryPath, fileType);

            return files;
        }

        private static bool isValidPath(string directoryPath)
        {
            if (!String.IsNullOrEmpty(directoryPath) && Path.IsPathFullyQualified(directoryPath)) return true;
            return false;
        }
    }
}
