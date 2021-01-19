using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void FileLogger_AppendsLogsToFile()
        {
            string message1 = "What is the average air speed velocity of an unladen swallow?";
            string message2 = "African or European?";

            if(File.Exists("fileLoggerTest.txt"))
                File.Delete("fileLoggerTest.txt");
        
            LogFactory logFactory = new LogFactory();
            logFactory.configureFileLogger("fileLoggerTest.txt");

            FileLogger fileLogger = (FileLogger)logFactory.CreateLogger(nameof(FileLoggerTests));

            fileLogger.Log(LogLevel.Warning, message1);
            fileLogger.Log(LogLevel.Warning, message2);

            StreamReader testFileLoggerReader = new StreamReader("fileLoggerTest.txt");
            var line1 = testFileLoggerReader.ReadLine();
            var line2 = testFileLoggerReader.ReadLine();
            testFileLoggerReader.Close();
            
            Assert.AreEqual(line1, $"{System.DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy")} FileLoggerTests {LogLevel.Warning} {message1}");
            Assert.AreEqual(line2, $"{System.DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy")} FileLoggerTests {LogLevel.Warning} {message2}");
          }
    }
}
