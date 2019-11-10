using System;
using System.Linq;

class UpgradedMatcher
{
    static void Main(string[] args)
    {
        string[] products = Console.ReadLine().Split(' ');
        long[] productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        decimal[] productsPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        string line;

        while ((line = Console.ReadLine()) != "done")
        {
            string[] stringParams = line.Split(' ');

            string product = stringParams[0];

            int index = Array.IndexOf(products, product);
            decimal productPrice = productsPrices[index];
            long productQuantity = 0;

            if (index < productsQuantities.Length)
            {
                productQuantity = productsQuantities[index];
            }

            long orderedQuantity = long.Parse(stringParams[1]);

            if (orderedQuantity <= productQuantity)
            {
                decimal totalOrderPrice = orderedQuantity * productPrice;

                Console.WriteLine($"{product} x {orderedQuantity} costs {totalOrderPrice:f2}");

                if (productQuantity > 0)
                {
                    productsQuantities[index] -= orderedQuantity;
                }
            }
            else
            {
                Console.WriteLine($"We do not have enough {product}");
            }
        }
    }
}