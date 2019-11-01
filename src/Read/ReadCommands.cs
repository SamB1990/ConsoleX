using System.Collections.Generic;
using System.Text.RegularExpressions;
using Console.CommandHandler;

namespace System
{
    public static partial class ConsoleX
    {
        public static IEnumerable<IExecutableCommand> ReadCommands()
        {
            var input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, @"(--\w*|-\w*)+\w*[^-]*", RegexOptions.Multiline))
            {
                var commandString = match.Groups[1].ToString();
                yield return new ExecutableCommand()
                {
                    Command = new Command(commandString),
                    Arguments = GetArguments(match.Groups[0].ToString().Replace(commandString, ""))
                };
            }
        }

        public static IEnumerable<string> GetArguments(string argumentString)
        {
            if (string.IsNullOrWhiteSpace(argumentString))
                return new string[] { };

            var match = Regex.Match(argumentString.Trim(), @"(?<=\[).+?(?=\])");

            return !match.Success ? new string[] { argumentString } : match.Value.Split(',');
        }
    }
}
