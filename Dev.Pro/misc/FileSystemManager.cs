namespace Dev.Pro.Helpers
{
    public class FileSystemManager
    {
        public void deleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string getPath(string fileName)
        {
            return Path.Combine(Path.GetTempPath(), fileName);
        }
        public string getAllFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
