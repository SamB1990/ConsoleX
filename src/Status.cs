

namespace System
{
    public static partial class ConsoleX
    {
        public enum MessageStatus
        {
            Default = 0,
            Success = 1,
            Error = 2,
            Warning = 3,
            Info = 4,
            Question = 5
        }

        private const string defaultStatusText = "";
        private const string successStatusText = "[Success]";
        private const string errorStatusText = "[Error]";
        private const string warningStatusText = "[Warning]";
        private const string infoStatusText = "[Info]";
        private const string questionStatusText = "[Question]";

        public static string GetStatusText(this MessageStatus status)
        {
            return status switch
            {
                MessageStatus.Default => defaultStatusText,
                MessageStatus.Success => successStatusText,
                MessageStatus.Error => errorStatusText,
                MessageStatus.Warning => warningStatusText,
                MessageStatus.Info => infoStatusText,
                MessageStatus.Question => questionStatusText,
                _ => defaultStatusText
            };
        }
        
        public static void WriteSuccessLine(string message, LogLevel level = LogLevel.none)
        {
            WriteLine(message, MessageStatus.Success, level.NoneToStatusDefault(MessageStatus.Success));
        }

        public static void WriteInfoLine(string message, LogLevel level = LogLevel.none)
        {
            WriteLine(message, MessageStatus.Info, level.NoneToStatusDefault(MessageStatus.Info));
        }

        public static void WriteWarningLine(string message, LogLevel level = LogLevel.none)
        {
            WriteLine(message, MessageStatus.Warning, level.NoneToStatusDefault(MessageStatus.Warning));
        }


        public static void WriteError(Exception e, LogLevel level = LogLevel.none)
        {
            while (true)
            {
                WriteLine(e.Message, MessageStatus.Error, level.NoneToStatusDefault(MessageStatus.Error));
                if (e.InnerException != null)
                {
                    e = e.InnerException;
                    continue;
                }
                break;
            }
        }
    }
}
