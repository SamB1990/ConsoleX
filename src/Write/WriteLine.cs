
namespace System
{
    public static partial class ConsoleX
    {
        public static void WriteLine(string message, MessageStatus status = MessageStatus.Default, LogLevel level = LogLevel.none)
        {
            if (!level.TestLogLevel()) return;

            Console.ForegroundColor = GetStatusColor(status);

            Console.WriteLine(BuildLine(message, status));

            Console.ForegroundColor = defaultStatusColor;
        }
    }
}
