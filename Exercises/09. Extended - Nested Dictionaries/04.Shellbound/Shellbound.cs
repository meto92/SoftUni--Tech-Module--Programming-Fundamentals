using System;
using System.Linq;
using System.Collections.Generic;

class Shellbound
{
    static void Main(string[] args)
    {
        Dictionary<string, List<long>> shellsByRegion = new Dictionary<string, List<long>>();

        string input;

        while ((input = Console.ReadLine()) != "Aggregate")
        {
            string[] items = input.Split(' ');

            string region = items[0];
            int shellSize = int.Parse(items[1]);

            if (!shellsByRegion.ContainsKey(region))
            {
                shellsByRegion[region] = new List<long>();
            }

            if (!shellsByRegion[region].Contains(shellSize))
            {
                shellsByRegion[region].Add(shellSize);
            }
        }

        foreach (KeyValuePair<string, List<long>> pair in shellsByRegion)
        {
            string region = pair.Key;
            long sumOfShells = pair.Value.Sum();
            double giantShell = Math.Ceiling(sumOfShells - pair.Value.Average());

            Console.WriteLine($"{region} -> {string.Join(", ", pair.Value)} ({giantShell})");
        }
    }
}