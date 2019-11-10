using System;
using System.Text;
using System.Text.RegularExpressions;

class KeyReplacer
{
    static void Main(string[] args)
    {
        string keys = Console.ReadLine();
        string text = Console.ReadLine();

        Regex firstKeyPattern = new Regex(@"^([a-zA-Z]+)(\||<|\\)");
        Regex secondKeyPattern = new Regex(@"(\||<|\\)([a-zA-Z]+)$");

        string firstKey = firstKeyPattern.Match(keys).Groups[1].Value;
        string secondKey = secondKeyPattern.Match(keys).Groups[2].Value;

        Regex pattern = new Regex($"{firstKey}(.*?){secondKey}");
        StringBuilder result = new StringBuilder();

        foreach (Match match in pattern.Matches(text))
        {
            result.Append(match.Groups[1].Value);
        }

        if (result.Length > 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Empty result");
        }
    }
}