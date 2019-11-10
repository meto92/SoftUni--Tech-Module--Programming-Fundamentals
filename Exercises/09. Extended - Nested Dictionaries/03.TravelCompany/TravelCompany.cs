using System;
using System.Linq;
using System.Collections.Generic;

class TravelCompany
{
    static void AddTransports(Dictionary<string, Dictionary<string, int>> companyInfo)
    {
        string input;

        while ((input = Console.ReadLine()) != "ready")
        {
            string[] items = input.Split(':');

            string city = items[0];
            string[] pairs = items[1].Split(',');

            if (!companyInfo.ContainsKey(city))
            {
                companyInfo[city] = new Dictionary<string, int>();
            }

            for (int i = 0; i < pairs.Length; i++)
            {
                string[] values = pairs[i].Split('-');

                string type = values[0];
                int capacity = int.Parse(values[1]);

                companyInfo[city][type] = capacity;
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> companyInfo = new Dictionary<string, Dictionary<string, int>>();

        AddTransports(companyInfo);

        string input;

        while ((input = Console.ReadLine()) != "travel time!")
        {
            string[] items = input.Split(' ');

            string city = items[0];
            int peopleCount = int.Parse(items[1]);

            int transportCapacities = companyInfo[city].Values.Sum();

            if (peopleCount <= transportCapacities)
            {
                Console.WriteLine($"{city} -> all {peopleCount} accommodated");
            }
            else
            {
                Console.WriteLine($"{city} -> all except {peopleCount - transportCapacities} accommodated");
            }
        }
    }
}