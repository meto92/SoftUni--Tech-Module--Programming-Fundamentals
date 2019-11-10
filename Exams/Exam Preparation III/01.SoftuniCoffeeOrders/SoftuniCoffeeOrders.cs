using System;
using System.Globalization;

class SoftuniCoffeeOrders
{
    static void Main(string[] args)
    {
        int ordersCount = int.Parse(Console.ReadLine());

        decimal totalPrice = 0;

        for (int i = 0; i < ordersCount; i++)
        {
            decimal capsulePrice = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            int capsulesCount = int.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            decimal price = capsulePrice * daysInMonth * capsulesCount;

            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            totalPrice += price;
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}