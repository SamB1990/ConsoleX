
namespace System
{
    public static partial class ConsoleX
    {
        public static bool WriteCheck(string Question)
        {
            ConsoleKey response;
            do
            {
                ConsoleX.Write($"{  Question } [y/n]", MessageStatus.Question);

                response = Console.ReadKey(false).Key;

                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            Console.ForegroundColor = defaultStatusColor;

            return response == ConsoleKey.Y;
        }
    }
}
