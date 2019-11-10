using System;
using System.Linq;
using System.Collections.Generic;

class Sale
{
    private string town;
    private string product;
    private decimal price;
    private double quantity;

    public string Town
    {
        get { return town; }
        set { town = value; }
    }

    public string Product
    {
        get { return product; }
        set { product = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public double Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public Sale(string town, string product, decimal price, double quantity)
    {
        Town = town;
        Product = product;
        Price = price;
        Quantity = quantity;
    }
}

class SalesReport
{
    static Sale ReadSale()
    {
        string[] saleParams = Console.ReadLine().Split(' ');

        string town = saleParams[0];
        string product = saleParams[1];
        decimal price = decimal.Parse(saleParams[2]);
        double quantity = double.Parse(saleParams[3]);

        return new Sale(town, product, price, quantity);
    }

    static void Main(string[] args)
    {
        int numberOfSales = int.Parse(Console.ReadLine());

        List<Sale> sales = new List<Sale>();

        for (int i = 0; i < numberOfSales; i++)
        {
            Sale sale = ReadSale();

            sales.Add(sale);
        }

        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

        foreach (Sale sale in sales)
        {
            if (!salesByTown.ContainsKey(sale.Town))
            {
                salesByTown[sale.Town] = 0;
            }

            salesByTown[sale.Town] += (decimal)sale.Quantity * sale.Price;
        }

        Console.WriteLine(string.Join(Environment.NewLine, salesByTown.Select(p => $"{p.Key} -> {p.Value:f2}")));
    }
}