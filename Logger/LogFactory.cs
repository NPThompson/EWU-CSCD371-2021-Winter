namespace Logger
{
    public class LogFactory
    {
        private string _fileLoggerFilePath;

        public void configureFileLogger(string filePath)
        {
            _fileLoggerFilePath = filePath;
        }

        public BaseLogger CreateLogger(string initClassName)
        {
            if(_fileLoggerFilePath == null)
                return null;
            else return new FileLogger{ className = initClassName, filePath = _fileLoggerFilePath };      
        }
    }
}
