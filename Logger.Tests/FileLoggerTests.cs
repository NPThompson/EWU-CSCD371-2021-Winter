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
            if(File.Exists("fileLoggerTest.txt"))
                File.Delete("fileLoggerTest.txt");
        
            LogFactory logFactory = new LogFactory();
            logFactory.configureFileLogger("fileLoggerTest.txt");

            FileLogger fileLogger = (FileLogger)logFactory.CreateLogger("FileLogger");

            fileLogger.Log(LogLevel.Warning, "What is the average air speed velocity of an unladen swallow?");
            fileLogger.Log(LogLevel.Warning, "African or European?");

            StreamReader testFileLoggerReader = new StreamReader("fileLoggerTest.txt");
            var lastLoggedMessage = testFileLoggerReader.ReadLine();
            testFileLoggerReader.Close();
            
            // because the time changes so quickly, we chop off the first 8 characters (hh:mm:ss)
            lastLoggedMessage = lastLoggedMessage.Substring(8, lastLoggedMessage.Length-1);
            System.Console.WriteLine(lastLoggedMessage);

            Assert.AreEqual(lastLoggedMessage, "My Friends Call me Tim");
        }
    }
}
