using Dev.Pro.Helpers;

namespace Dev.Pro.Tasks
{
    public class FileLogger
    {
        public void log_message(string filePath, string message, LogLevelEnum level)
        {
            File.AppendAllText(filePath, $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] [{level}] {message}" + Environment.NewLine);
        }
    }
}
