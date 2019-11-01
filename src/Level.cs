namespace System
{
    public static partial class ConsoleX
    {
        public enum LogLevel
        {
            Debug = 3,
            Verbose = 2,
            basic = 1,
            none = 0
        }

        public static LogLevel DefaultSuccessLogLevel { get; set; } = LogLevel.Verbose;
        public static LogLevel DefaultInfoLogLevel { get; set; } = LogLevel.Verbose;
        public static LogLevel DefaultWarningLogLevel { get; set; } = LogLevel.Verbose;
        public static LogLevel DefaultErrorLogLevel { get; set; } = LogLevel.Debug;

        private static LogLevel _loggerLevel = LogLevel.basic;

        public static LogLevel LoggerLevel 
        { 
            get => _loggerLevel;
            set => _loggerLevel = (value == LogLevel.none ? LogLevel.basic : value);
        }


        private static LogLevel NoneToStatusDefault(this LogLevel LogLevel, MessageStatus status)
        {
            if (LogLevel != LogLevel.none) return LogLevel;

            return status switch
            {
                MessageStatus.Default => LogLevel.basic,
                MessageStatus.Success => DefaultSuccessLogLevel,
                MessageStatus.Error => DefaultErrorLogLevel,
                MessageStatus.Warning => DefaultWarningLogLevel,
                MessageStatus.Info => DefaultInfoLogLevel,
                MessageStatus.Question => LogLevel.basic,
                _ => LogLevel.basic
            };
        }


        private static bool TestLogLevel(this LogLevel LogLevel)
        {
            if (LogLevel == LogLevel.none)
                LogLevel = LogLevel.basic;

            return LogLevel <= LoggerLevel;
        }
    }
}
