using System;

class SweetDessert
{
    static void Main(string[] args)
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guestsCount = int.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        while (guestsCount % 6 != 0)
        {
            guestsCount++;
        }

        decimal moneyNeeded = guestsCount / 6 * (2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice);

        if (cash >= moneyNeeded)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
        }
        else
        {
            decimal moreMoneyNeeded = moneyNeeded - cash;

            Console.WriteLine($"Ivancho will have to withdraw money - he will need {moreMoneyNeeded:f2}lv more.");
        }
    }
}