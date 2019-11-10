using System;
using System.Collections.Generic;

class Key_Key_Value_Value
{
    static void Main(string[] args)
    {
        string key = Console.ReadLine();
        string value = Console.ReadLine();
        int linesCount = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < linesCount; i++)
        {
            string[] pair = Console.ReadLine().Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

            string k = pair[0];
            string[] values = pair[1].Split(';');

            if (!dict.ContainsKey(k))
            {
                dict[k] = new List<string>();
            }

            dict[k].AddRange(values);
        }

        foreach (KeyValuePair<string, List<string>> pair in dict)
        {
            if (pair.Key.Contains(key))
            {
                Console.WriteLine($"{pair.Key}:");

                foreach (string str in pair.Value)
                {
                    if (str.Contains(value))
                    {
                        Console.WriteLine($"-{str}");
                    }
                }
            }
        }
    }
}