
namespace System
{
    public static partial class ConsoleX
    {
        internal static string BuildLine(string message, MessageStatus status = MessageStatus.Default)
        {
            if (ShowStatus)
            {
                message = $"{status.GetStatusText()} {message}";
            }
            if (ShowTime)
            {
                message = $"{DateTime.Now.ToString(TimeFormat)} {message}";
            }

            return message;
        }
    }
}
