using System.Text.RegularExpressions;

namespace DelegateProjectTask
{
    public class ConsoleParser
    {
        public delegate void OnWord();
        public delegate void OnNumber();
        public delegate void OnJunk();

        public void Run(OnWord word, OnNumber num, OnJunk junk) { 

            while (true)
            {
                Console.WriteLine("enter the word");

                string input = Console.ReadLine().Trim();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                else if (ContainsNumbersAndAlphabets(input) || IsAlphabetic(input))
                {
                    word();
                }

                else if (IsNumeric(input))
                {
                    num();
                }
                else
                {
                    junk();
                }
            }

        }
        public static bool ContainsNumbersAndAlphabets(string input)
        {
            // Use a regular expression to check if the input contains both numbers and alphabetic characters
            return Regex.IsMatch(input, "^(?=.*[0-9])(?=.*[a-zA-Z])");
        }
        public static bool IsAlphabetic(string input)
        {
            // Use a regular expression to check if the input contains only alphabetic characters
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }
        public static bool IsNumeric(string input)
        {
            // Use a regular expression to check if the input contains only numeric characters
            return Regex.IsMatch(input, "^[0-9]+$");
        }
    }
}
