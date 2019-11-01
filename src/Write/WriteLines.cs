using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static partial class ConsoleX
    {
        public static void WriteLines(IEnumerable<string> messages, ConsoleX.MessageStatus status = ConsoleX.MessageStatus.Default, ConsoleX.LogLevel level = ConsoleX.LogLevel.none)
        {
            foreach (var message in messages)
            {
                ConsoleX.WriteLine(message, status, level);
            }
        }
    }
}
