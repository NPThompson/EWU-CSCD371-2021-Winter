using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string filePath {get; set;}

        public override void Log(LogLevel logLevel, string message)
        {
            StreamWriter LogFile = File.AppendText(filePath);
            LogFile.WriteLine($"{System.DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy")} {className} {logLevel} {message}");
            LogFile.Close();
        }
    }
}
