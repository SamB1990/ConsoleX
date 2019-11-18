
namespace System
{
    public static partial class ConsoleX
    {
        public static string WriteQuestion(string Question, MessageStatus messageStatus = MessageStatus.Question)
        {
            ConsoleX.Write($"{  Question }", messageStatus);
            return Console.ReadLine();
        }
    }
}
