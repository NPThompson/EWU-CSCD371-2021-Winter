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
         FileLogger myLogger = (FileLogger)(new LogFactory()).CreateLogger("FileLogger");

         // Act
                  
         // Test
         Assert.AreEqual(myLogger.name, "FileLogger");
        }   
    }
}
