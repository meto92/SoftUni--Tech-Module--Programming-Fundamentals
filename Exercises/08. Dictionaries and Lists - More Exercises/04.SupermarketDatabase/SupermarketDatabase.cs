using System;
using System.Collections.Generic;

class SupermarketDatabase
{
    static void AddProduct(Dictionary<string, decimal[]> productsInfo, string product, decimal productPrice, int productQuantity)
    {
        if (!productsInfo.ContainsKey(product))
        {
            productsInfo[product] = new decimal[2];
        }

        productsInfo[product][0] = productPrice;
        productsInfo[product][1] += productQuantity;
    }

    static void PrintResult(Dictionary<string, decimal[]> productsInfo)
    {
        decimal grandTotal = 0m;

        foreach (KeyValuePair<string, decimal[]> pair in productsInfo)
        {
            string product = pair.Key;
            decimal price = productsInfo[product][0];
            int quantity = (int)productsInfo[product][1];
            decimal total = price * quantity;

            grandTotal += total;

            Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${total:F2}");
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:f2}");
    }

    static void Main(string[] args)
    {
        Dictionary<string, decimal[]> productsInfo = new Dictionary<string, decimal[]>();

        string input;

        while ((input = Console.ReadLine()) != "stocked")
        {
            string[] items = input.Split();

            string product = items[0];
            decimal productPrice = decimal.Parse(items[1]);
            int productQuantity = int.Parse(items[2]);

            AddProduct(productsInfo, product, productPrice, productQuantity);
        }

        PrintResult(productsInfo);
    }
}