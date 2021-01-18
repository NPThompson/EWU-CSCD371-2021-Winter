namespace Logger
{
    public class LogFactory
    {
        private string _fileLoggerFilePath;

        public void configureFileLogger(string filePath)
        {
            _fileLoggerFilePath = filePath;
        }

        public BaseLogger CreateLogger(string className)
        {
            switch(className)
            {
                case "FileLogger":
                    if(_fileLoggerFilePath == null)
                        return null;
                    return new FileLogger{ name = className };
                break;
            }
            return null;
        }
    }
}
