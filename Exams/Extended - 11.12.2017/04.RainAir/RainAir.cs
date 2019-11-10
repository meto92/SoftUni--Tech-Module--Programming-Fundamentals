using System;
using System.Linq;
using System.Collections.Generic;

class RainAir
{
    static void Main(string[] args)
    {
        SortedDictionary<string, List<int>> flightsByCustomers = new SortedDictionary<string, List<int>>();

        string input;

        while ((input = Console.ReadLine()) != "I believe I can fly!")
        {
            if (input.Contains("="))
            {
                string[] customers = input.Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries);

                string firstCustomer = customers[0];
                string secondCustomer = customers[1];

                flightsByCustomers[firstCustomer] = new List<int>();
                flightsByCustomers[firstCustomer].AddRange(flightsByCustomers[secondCustomer]);
            }
            else
            {
                string[] items = input.Split(' ');

                string customer = items[0];
                int[] flights = items.Skip(1).Select(int.Parse).ToArray();

                if (!flightsByCustomers.ContainsKey(customer))
                {
                    flightsByCustomers[customer] = new List<int>();
                }

                flightsByCustomers[customer].AddRange(flights);
            }
        }

        foreach (KeyValuePair<string, List<int>> pair in flightsByCustomers.OrderByDescending(pair => pair.Value.Count))
        {
            string customer = pair.Key;
            List<int> flights = pair.Value.OrderBy(p => p).ToList();

            Console.WriteLine($"#{customer} ::: {string.Join(", ", flights)}");
        }
    }
}