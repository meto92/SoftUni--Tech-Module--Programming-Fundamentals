using System;
using System.Text.RegularExpressions;

class AnonymousVox
{
    static void Main(string[] args)
    {
        string encodedText = Console.ReadLine();
        string[] placeholders = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

        Regex pattern = new Regex(@"([a-zA-Z]+)([^\1]+)(\1)");

        MatchCollection matches = pattern.Matches(encodedText);

        for (int i = 0; i < matches.Count; i++)
        {
            Match match = matches[i];

            if (placeholders.Length > i)
            {
                string replacement = string.Format("{0}{1}{0}", match.Groups[1].Value, placeholders[i]);

                encodedText = encodedText.Replace(match.Value, replacement);
            }
        }

        Console.WriteLine(encodedText);
    }
}