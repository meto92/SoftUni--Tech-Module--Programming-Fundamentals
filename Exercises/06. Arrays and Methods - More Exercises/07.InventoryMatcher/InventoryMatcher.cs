using System;
using System.Linq;

class InventoryMatcher
{
    static void Main(string[] args)
    {
        string[] products = Console.ReadLine().Split(' ');
        long[] productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        decimal[] productsPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        string product;

        while ((product = Console.ReadLine()) != "done")
        {
            int index = Array.IndexOf(products, product);
            decimal productPrice = productsPrices[index];
            long productQuantity = productsQuantities[index];

            Console.WriteLine($"{product} costs: {productPrice}; Available quantity: {productQuantity}");
        }
    }
}