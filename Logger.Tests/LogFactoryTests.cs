using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void LogFactory_SetsClassName()
        {
         // Arrange
         LogFactory myLogFactory = new LogFactory();
         myLogFactory.configureFileLogger("foobar");

         FileLogger myLogger = (FileLogger)myLogFactory.CreateLogger(nameof(LogFactoryTests));
                  
         // Test
         Assert.AreEqual(myLogger.className, nameof(LogFactoryTests));
        }

        [TestMethod]
        public void LogFactory_ReturnsNull_IfFileLoggerNotConfigured()
        {
            FileLogger myLogger = (FileLogger)(new LogFactory()).CreateLogger("FileLogger");

            Assert.IsNull(myLogger);
        }
    }
}
