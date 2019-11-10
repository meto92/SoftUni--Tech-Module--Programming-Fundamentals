using System;
using System.Collections.Generic;

class RestaurantDiscount
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        if (count > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        string[] halls =
        {
            "Small Hall",
            "Terrace",
            "Great Hall"
        };

        string[] packages =
        {
            "Normal",
            "Gold",
            "Platinum"
        };

        Dictionary<string, int> hallsPrices = new Dictionary<string, int>()
        {
            {halls[0], 2500},
            {halls[1], 5000},
            {halls[2], 7500}
        };

        Dictionary<string, int> packagesDiscounts = new Dictionary<string, int>()
        {
            {packages[0], 5},
            {packages[1], 10},
            {packages[2], 15}
        };

        Dictionary<string, decimal> packagesPrices = new Dictionary<string, decimal>()
        {
            {packages[0], 500},
            {packages[1], 750},
            {packages[2], 1000}
        };

        string hall = null;

        if (count <= 50)
        {
            hall = halls[0];
        }
        else if (count <= 100)
        {
            hall = halls[1];
        }
        else if (count <= 120)
        {
            hall = halls[2];
        }

        int packageDiscount = packagesDiscounts[package];
        decimal packagePrice = packagesPrices[package];

        decimal totalPrice = (hallsPrices[hall] + packagePrice) * (1 - packageDiscount / 100.0m);
        decimal price = totalPrice / count;

        Console.WriteLine($"We can offer you the {hall}");
        Console.WriteLine($"The price per person is {price:f2}$");
    }
}