
namespace System
{
    public static partial class ConsoleX
    {
        public static void Write(string message, MessageStatus status = MessageStatus.Default, LogLevel level = LogLevel.none)
        {
            if (!level.TestLogLevel()) return;

            Console.ForegroundColor = GetStatusColor(status);

            Console.Write(BuildLine(message, status));

            Console.ForegroundColor = defaultStatusColor;
        }
    }
}
