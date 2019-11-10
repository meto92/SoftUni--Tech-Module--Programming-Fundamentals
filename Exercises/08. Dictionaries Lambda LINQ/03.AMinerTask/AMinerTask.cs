using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main(string[] args)
    {
        Dictionary<string, long> resourcesQuantities = new Dictionary<string, long>();

        string line;

        while ((line = Console.ReadLine()) != "stop")
        {
            string resource = line;
            int quantity = int.Parse(Console.ReadLine());

            if (!resourcesQuantities.ContainsKey(resource))
            {
                resourcesQuantities[resource] = 0;
            }

            resourcesQuantities[resource] += quantity;
        }

        foreach (KeyValuePair<string, long> pair in resourcesQuantities)
        {
            string resource = pair.Key;
            long resourceQuantity = resourcesQuantities[resource];

            Console.WriteLine($"{resource} -> {resourceQuantity}");
        }
    }
}