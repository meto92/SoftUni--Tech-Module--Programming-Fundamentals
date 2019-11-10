using System;

class SweetDessert
{
    static void Main(string[] args)
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guestsCount = int.Parse(Console.ReadLine());
        decimal bananaPrie = decimal.Parse(Console.ReadLine());
        decimal eggPrie = decimal.Parse(Console.ReadLine());
        decimal berriesPrie = decimal.Parse(Console.ReadLine());

        int portions = (int)Math.Ceiling(guestsCount / 6.0);

        decimal productsPrice = portions * (2 * bananaPrie + 4 * eggPrie + 0.2m * berriesPrie);

        if (cash >= productsPrice)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {productsPrice:f2}lv.");
        }
        else
        {
            decimal neededMoney = productsPrice - cash;

            Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
        }
    }
}