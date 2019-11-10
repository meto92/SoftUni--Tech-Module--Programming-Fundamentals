using System;
using System.Linq;
using System.Collections.Generic;

class Nacepin
{
    static void Main(string[] args)
    {
        decimal priceInUS = decimal.Parse(Console.ReadLine());
        long boxWeightInUS = long.Parse(Console.ReadLine());
        decimal priceInUK = decimal.Parse(Console.ReadLine());
        long boxWeightInUK = long.Parse(Console.ReadLine());
        decimal priceInChina = decimal.Parse(Console.ReadLine());
        long boxWeightInChina = long.Parse(Console.ReadLine());

        Dictionary<string, decimal> prices = new Dictionary<string, decimal>
            {
                {"US",  priceInUS / 0.58m / boxWeightInUS },
                {"UK",  priceInUK / 0.41m / boxWeightInUK },
                {"Chinese", priceInChina * 0.27m / boxWeightInChina }
            };

        foreach (KeyValuePair<string, decimal> pair in prices.OrderBy(p => p.Value).Take(1))
        {
            Console.WriteLine($"{pair.Key} store. {pair.Value:f2} lv/kg");
        }

        Console.WriteLine($"Difference {prices.Values.Max() - prices.Values.Min():f2} lv/kg");
    }
}