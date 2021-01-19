namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger logger, string message)
        {
            if(logger == null)
            throw new System.ArgumentNullException();

            logger.Log(LogLevel.Error, message);
        }

        //Allows one to write: MyLogger.Error("Some message {0} {1}", 12345, 67890 );
        public static void Error(this BaseLogger logger, string formatMessage, params object[] insertIntoMessage)
        {
            logger.Log(LogLevel.Error, string.Format(formatMessage, insertIntoMessage));
        }

        public static void Information(this BaseLogger logger, string formatMessage, params object[] insertIntoMessage)
        {
             logger.Log(LogLevel.Information, string.Format(formatMessage, insertIntoMessage));
        }

        public static void Warning(this BaseLogger logger, string formatMessage, params object[] insertIntoMessage)
        {
             logger.Log(LogLevel.Warning, string.Format(formatMessage, insertIntoMessage));
        }

        public static void Debug(this BaseLogger logger, string formatMessage, params object[] insertIntoMessage)
        {
             logger.Log(LogLevel.Debug, string.Format(formatMessage, insertIntoMessage));
        }
    }
}
