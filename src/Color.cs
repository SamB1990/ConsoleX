
namespace System
{
    public static partial class ConsoleX
    {
        private const ConsoleColor defaultStatusColor = ConsoleColor.Gray;
        private const ConsoleColor successStatusColor = ConsoleColor.Green;
        private const ConsoleColor errorStatusColor = ConsoleColor.Red;
        private const ConsoleColor warningStatusColor = ConsoleColor.Yellow;
        private const ConsoleColor infoStatusColor = ConsoleColor.Cyan;
        private const ConsoleColor questionStatusColor = ConsoleColor.DarkYellow;

        public static ConsoleColor GetStatusColor(MessageStatus status)
        {
            return status switch
            {
                MessageStatus.Default => defaultStatusColor,
                MessageStatus.Success => successStatusColor,
                MessageStatus.Error => errorStatusColor,
                MessageStatus.Warning => warningStatusColor,
                MessageStatus.Info => infoStatusColor,
                MessageStatus.Question => questionStatusColor,
                _ => defaultStatusColor
            };
        }
    }
}
