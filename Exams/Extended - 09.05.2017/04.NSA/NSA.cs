using System;
using System.Linq;
using System.Collections.Generic;

class NSA
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> spiesInfo = new Dictionary<string, Dictionary<string, int>>();

        string input;

        while ((input = Console.ReadLine()) != "quit")
        {
            string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.None);

            string countryName = tokens[0];
            string spyName = tokens[1];
            int daysInService = int.Parse(tokens[2]);

            if (!spiesInfo.ContainsKey(countryName))
            {
                spiesInfo[countryName] = new Dictionary<string, int>();
            }

            spiesInfo[countryName][spyName] = daysInService;
        }

        foreach (KeyValuePair<string, Dictionary<string, int>> pair in spiesInfo.OrderByDescending(p => p.Value.Count))
        {
            string country = pair.Key;

            Console.WriteLine($"Country: {pair.Key}");

            foreach (KeyValuePair<string, int> spyInfo in spiesInfo[country].OrderByDescending(p => p.Value))
            {
                string spy = spyInfo.Key;
                int daysInService = spyInfo.Value;

                Console.WriteLine($"**{spy} : {daysInService}");
            }
        }
    }
}