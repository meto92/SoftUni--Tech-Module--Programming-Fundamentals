using System;
using System.Linq;
using System.Collections.Generic;

class PopulationCounter
{
    static void ReadAndProcessInput(Dictionary<string, Dictionary<string, long>> countriesStatistics)
    {
        string input;

        while ((input = Console.ReadLine()) != "report")
        {
            string[] items = input.Split('|');

            string city = items[0];
            string country = items[1];
            int population = int.Parse(items[2]);

            if (!countriesStatistics.ContainsKey(country))
            {
                countriesStatistics[country] = new Dictionary<string, long>();
            }

            countriesStatistics[country][city] = population;
        }
    }

    static void PrintStatistics(Dictionary<string, Dictionary<string, long>> countriesStatistics)
    {
        foreach (KeyValuePair<string, Dictionary<string, long>> pair in countriesStatistics.OrderByDescending(p => countriesStatistics[p.Key].Values.Sum()))
        {
            string country = pair.Key;

            Console.WriteLine($"{country} (total population: {countriesStatistics[country].Values.Sum()})");

            foreach (KeyValuePair<string, long> p in countriesStatistics[country].OrderByDescending(p => p.Value))
            {
                string city = p.Key;
                long population = p.Value;

                Console.WriteLine($"=>{city}: {population}");
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> countriesPopulationStatistics = new Dictionary<string, Dictionary<string, long>>();

        ReadAndProcessInput(countriesPopulationStatistics);
        PrintStatistics(countriesPopulationStatistics);
    }
}