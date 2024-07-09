using Dev.Pro.Helpers;
using Dev.Pro.Tasks;
using NUnit.Framework.Internal;

namespace taskTests
{
    public class LoggerScenarios
    {
        private string filePath;
        private FileLogger _logger;
        private FileSystemManager _Manager;

        [SetUp]
        public void SetUp()
        {
            _Manager = new FileSystemManager();
            _logger = new FileLogger();
            filePath = _Manager.getPath("application.log");
        }

        [Test]
        public void Log_Message_Should_Write_Log_Info_Entry()
        {
            String message = "User logged in";
            _logger.log_message(filePath, message, LogLevelEnum.INFO);
            string logContent = _Manager.getAllFileContent(filePath);
            Assert.IsTrue(logContent.Contains(message));
            Assert.IsTrue(logContent.Contains(LogLevelEnum.INFO.ToString()));
        }

        [Test]
        public void Log_Message_Should_Write_Log_Warning_Entry()
        {
            String message = "Failed login attempt";
            _logger.log_message(filePath, message, LogLevelEnum.WARNING);
            string logContent = _Manager.getAllFileContent(filePath);
            Assert.IsTrue(logContent.Contains(message));
            Assert.IsTrue(logContent.Contains(LogLevelEnum.WARNING.ToString()));
        }

        [TearDown]
        public void TearDown()
        {
            _Manager.deleteFile(filePath);
        }
    }
}