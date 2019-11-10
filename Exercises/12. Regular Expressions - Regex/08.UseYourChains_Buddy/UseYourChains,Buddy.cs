using System;
using System.Text;
using System.Text.RegularExpressions;

class UseYourChains_Buddy
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Regex pattern = new Regex(@"(?<=<p>)(.*?)(?=<\/p>)");
        StringBuilder result = new StringBuilder();
        MatchCollection matches = pattern.Matches(text);

        foreach (Match match in matches)
        {
            result.Append(match.Groups[1].Value);
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (!char.IsLower(result[i]) && !char.IsDigit(result[i]))
            {
                result[i] = ' ';
            }
        }

        result = new StringBuilder(Regex.Replace(result.ToString(), "\\s+", " "));

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                result[i] = result[i] <= 'm' ? (char)(result[i] + 13) : (char)(result[i] - 13);
            }
        }

        Console.WriteLine(result);
    }
}