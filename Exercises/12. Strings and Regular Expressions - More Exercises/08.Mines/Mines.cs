using System;
using System.Text;
using System.Text.RegularExpressions;

class Mines
{
    static void DetonateMine(StringBuilder result, Match mine, char firstChar, char secondChar)
    {
        int minePower = Math.Abs(firstChar - secondChar);

        int startIndex = mine.Index - minePower,
            endIndex = mine.Index + minePower + 4;

        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (endIndex >= result.Length)
        {
            endIndex = result.Length;
        }

        for (int i = startIndex; i < endIndex; i++)
        {
            result[i] = '_';
        }
    }

    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Regex pattern = new Regex(@"<(.{2})>");

        MatchCollection mines = pattern.Matches(text);

        StringBuilder result = new StringBuilder(text);

        foreach (Match mine in mines)
        {
            string chars = mine.Groups[1].Value;

            char firstChar = chars[0];
            char secondChar = chars[1];

            DetonateMine(result, mine, firstChar, secondChar);
        }

        Console.WriteLine(result);
    }
}