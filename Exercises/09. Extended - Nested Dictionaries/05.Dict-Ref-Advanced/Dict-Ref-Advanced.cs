using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Dict_Ref_Advanced
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] items = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string key = items[0];
            string[] arr = items[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            
            if (Regex.IsMatch(arr[0], "^\\d+$"))
            {
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<int>();
                }

                dict[key].AddRange(arr.Select(int.Parse));
            }
            else
            {
                List<int> numbers;

                if (dict.TryGetValue(arr[0], out numbers))
                {
                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = new List<int>();
                    }

                    foreach (int num in numbers)
                    {
                        dict[key].Add(num);
                    }
                }
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine,
            dict.Select(p => $"{p.Key} === {string.Join(", ", p.Value)}")));
    }
}