using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string filePath {get; set;}

        public override void Log(LogLevel logLevel, string message)
        {
            if(!File.Exists(filePath))
               File.Create(filePath).Close(); //Create returns a FileStream, which I want to immediately close so that other processes can also get at the file

        }
    }
}
