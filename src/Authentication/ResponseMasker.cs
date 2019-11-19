
namespace System
{
    public static partial class ConsoleX
    {
        public static string ResponseMasker()
        {
            var response = "";
            do
            {
                var key = System.Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    response += key.KeyChar;
                    System.Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && response.Length > 0)
                    {
                        response = response.Substring(0, (response.Length - 1));
                        System.Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            Console.WriteLine();

            return response;
        }
    }
}
