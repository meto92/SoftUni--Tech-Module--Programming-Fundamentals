using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class QueryMess
{
    static string RemoveSpaces(string value)
    {
        value = Regex.Replace(value.Replace('+', ' ').Replace("%20", " ").Trim(), "\\s+", " ");

        return value;
    }

    static void Main(string[] args)
    {
        string input;

        while ((input = RemoveSpaces(Console.ReadLine())) != "END")
        {
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();

            string[] items = input.Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < items.Length; i++)
            {
                if (!items[i].Contains('='))
                {
                    continue;
                }

                string[] pair = items[i].Split('=');

                string key = pair[0].Trim();
                string value = pair[1].Trim();

                if (!pairs.ContainsKey(key))
                {
                    pairs[key] = new List<string>();
                }

                pairs[key].Add(value);
            }

            Console.WriteLine(string.Join("", pairs.Select(p => $"{p.Key}=[{string.Join(", ", p.Value)}]")));
        }
    }
}