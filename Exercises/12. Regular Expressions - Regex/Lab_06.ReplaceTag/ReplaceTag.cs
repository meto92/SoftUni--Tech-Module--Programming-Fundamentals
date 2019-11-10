using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main(string[] args)
    {
        StringBuilder html = new StringBuilder();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            html.Append($"{input}{Environment.NewLine}");
        }

        string htmlString = html.ToString();

        Regex pattern = new Regex(@"<\s*a(\s*href[^>]+)>(.+?)<\s*\/\s*a\s*>");

        foreach (Match tag in pattern.Matches(htmlString))
        {
            string oldValue = tag.Value;
            string newValue = $"[URL {tag.Groups[1].Value.Trim()}]{tag.Groups[2].Value.Trim()}[/URL]";

            htmlString = htmlString.Replace(oldValue, newValue);
        }

        Console.WriteLine(htmlString.TrimEnd());
    }
}