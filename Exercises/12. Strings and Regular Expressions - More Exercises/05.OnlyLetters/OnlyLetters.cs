using System;
using System.Text;
using System.Text.RegularExpressions;

class OnlyLetters
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"(\d+)([a-zA-Z])");

        string message = Console.ReadLine();

        StringBuilder result = new StringBuilder(message);

        while (true)
        {
            Match match = pattern.Match(result.ToString());

            if (!match.Success)
            {
                break;
            }

            char letter = char.Parse(match.Groups[2].Value);

            int index = match.Index;

            result[index] = letter;

            while (char.IsDigit(result[index + 1]))
            {
                result.Remove(index + 1, 1);
            }
        }

        Console.WriteLine(result);
    }
}