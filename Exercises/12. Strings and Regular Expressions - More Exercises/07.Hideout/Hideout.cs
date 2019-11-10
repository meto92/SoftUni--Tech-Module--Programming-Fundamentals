using System;
using System.Text.RegularExpressions;

class Hideout
{
    static bool IsSpecialRegexChar(char searchedCharacter)
    {
        return
            searchedCharacter == '^' ||
            searchedCharacter == '$' ||
            searchedCharacter == '.' ||
            searchedCharacter == '|' ||
            searchedCharacter == '?' ||
            searchedCharacter == '*' ||
            searchedCharacter == '+' ||
            searchedCharacter == '(' ||
            searchedCharacter == ')' ||
            searchedCharacter == '[' ||
            searchedCharacter == ']' ||
            searchedCharacter == '\\';
    }

    static void Main(string[] args)
    {
        string map = Console.ReadLine();

        while (true)
        {
            string[] array = Console.ReadLine().Split(' ');

            char searchedCharacter = char.Parse(array[0]);
            int minimumCount = int.Parse(array[1]);

            string pattern = searchedCharacter + "{" + minimumCount + ",}";

            if (IsSpecialRegexChar(searchedCharacter))
            {
                pattern = "\\" + pattern;
            }

            Regex regex = new Regex(pattern);

            Match match = regex.Match(map);

            if (match.Success)
            {
                int indexOfTheFirstChar = match.Index,
                    lengthOfTheFoundString = match.Length;

                Console.WriteLine($"Hideout found at index {indexOfTheFirstChar} and it is with size {lengthOfTheFoundString}!");
                break;
            }
        }
    }
}