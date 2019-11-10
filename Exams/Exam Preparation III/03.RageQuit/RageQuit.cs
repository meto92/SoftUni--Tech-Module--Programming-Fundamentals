using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();
        HashSet<char> uniqueSymbols = new HashSet<char>();
        MatchCollection matches = Regex.Matches(Console.ReadLine(), @"(\D+)(\d+)");

        foreach (Match match in matches)
        {
            string str = match.Groups[1].Value.ToUpper();
            int count = int.Parse(match.Groups[2].Value);

            if (count == 0)
            {
                continue;
            }

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                text.Append(str);
            }
            
            result.Append(text);
            text.ToString().ToUpper().ToList().ForEach(symbol => uniqueSymbols.Add(symbol));
        }

        Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
        Console.WriteLine(result);
    }
}