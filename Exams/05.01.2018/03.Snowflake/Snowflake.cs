using System;
using System.Text.RegularExpressions;

class Snowflake
{
    static void Main(string[] args)
    {
        string surfacePattern = @"[^a-zA-Z\d]+";
        string mantlePattern = @"[\d_]+";
        string corePattern = @"[a-zA-Z]+";

        string[] patterns =
        {
            surfacePattern,
            mantlePattern,
            $"{surfacePattern}{mantlePattern}({corePattern}){mantlePattern}{surfacePattern}",
            mantlePattern,
            surfacePattern
        };

        bool isValid = true;
        int coreLength = 0;

        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            Match match = Regex.Match(input, patterns[i]);

            if (!match.Success || match.Value.Length != input.Length)
            {
                isValid = false;
                break;
            }

            if (i == 2)
            {
                coreLength = match.Groups[1].Length;
            }
        }

        if (isValid)
        {
            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}