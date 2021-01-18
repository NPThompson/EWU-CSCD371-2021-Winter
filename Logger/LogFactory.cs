namespace Logger
{
    public class LogFactory
    {
        public BaseLogger CreateLogger(string className)
        {
            switch(className)
            {
                case "FileLogger":
                    return new FileLogger{ name = className };
                break;

                default: return null;
            }
        }
    }
}
