using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static partial class ConsoleX
    {
        public static string PasswordCheck()
        {
            ConsoleX.Write("Password:");
            return ConsoleX.ResponseMasker();
        }
    }
}
