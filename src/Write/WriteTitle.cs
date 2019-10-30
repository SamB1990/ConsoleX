// ReSharper disable FormatStringProblem

namespace System
{
    public static partial class ConsoleX
    {
        public static char TitleSplitter { get; set; } = '-';
         
        /// <summary>
        /// Set the Width of the consoleX title write (anything lower than 10 will be defaulted to 10)
        /// </summary>
        public static int TitleWidth  { get; set; } = 80;
        
        public static void WriteTitle(string title)
        {
            var maxLength = TitleWidth.ToEven();

            var splitter = TitleSplitter.ToString();

            var basePadLeft = (maxLength / 2) - 2;
            var basePadRight = (maxLength / 2) - 0;

            if (maxLength - 10 <= 0) TitleWidth  = 10;

            Encase(true, splitter, maxLength);
            foreach (var line in title.Wrap(maxLength - 8))
            {
                Console.WriteLine("{0,2} {1," + PadLeft(line.Length, basePadLeft) + "} {2," + PadRight(line.Length, basePadRight) + "}", splitter.Repeat(2), line, splitter.Repeat(2));
            }
            Encase(false, splitter, maxLength);
        }

        private static void Encase(bool isHeader, string splitter, int maxLength)
        {
            var loop = 1;
            while (loop <= 3)
            {
                if (isHeader && loop == 3 || !isHeader && loop == 1)
                {
                    Console.WriteLine("{0,2} {1,0} {2, " + (maxLength - 2) + "}", splitter.Repeat(2), "", splitter.Repeat(2));
                }
                else
                {
                    ConsoleX.WriteSplitter(splitter, maxLength + 2);
                }
                loop++;
            }
        }

        private static int PadLeft(int length, int basePadLeft)
        {
            return (basePadLeft + (length / 2));
        }

        private static int PadRight(int length, int basePadRight)
        {
            return (basePadRight - (length / 2));
        }
    }
}
