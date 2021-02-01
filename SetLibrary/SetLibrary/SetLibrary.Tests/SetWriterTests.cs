using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SetLibrary.Serialize.Tests
{
    [TestClass]
    public class SetWriterTests
    {
        void setup()
        {
            if (File.Exists("test.txt"))
                File.Delete("test.txt");
        }

        [TestMethod]
        public void SetWriter_DisposeFreesFile()
        {
            setup();

            SetWriter setWriter = new("test.txt");
            setWriter.Dispose();

            // if the setWriter's streamWriter has been disposed of, we should have no trouble opening the file with another StreamWriter
            StreamWriter streamWriter = new("test.txt");
        }

        public void SetWriter_WritesSetElementsToFile()
        {
            setup();

            NumSet set = new(3, 5, 8);

            using (SetWriter writer = new("test.txt"))
            {
                writer.Serialize(set);
            }

            StreamReader reader = new("test.txt");
            string fileAsString = reader.ReadToEnd();

            Assert.IsTrue(fileAsString.Contains('3'));
            Assert.IsTrue(fileAsString.Contains('5'));
            Assert.IsTrue(fileAsString.Contains('8'));
        }
    }
}
