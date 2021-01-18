namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger logger, string message)
        {
            if(logger == null)
            throw new System.ArgumentNullException();
        }

        //Allows one to write: MyLogger.Error("Some message {0} {1}", 12345, 67890 );
        public static void Error(this BaseLogger logger, string formatMessage, params object[] insertIntoMessage)
        {
            logger.Error(string.Format(formatMessage, insertIntoMessage));
        }
    }
}
