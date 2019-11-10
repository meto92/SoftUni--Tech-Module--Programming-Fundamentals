using System;

class CharityMarathon
{
    static void Main(string[] args)
    {
        int marathonDays = int.Parse(Console.ReadLine());
        int runners = int.Parse(Console.ReadLine());
        int averageLapsPerRunner = int.Parse(Console.ReadLine());
        int trackLength = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal moneyDonatedPerKilometer = decimal.Parse(Console.ReadLine());

        if (runners > marathonDays * trackCapacity)
        {
            runners = marathonDays * trackCapacity;
        }

        Console.WriteLine($"Money raised: {moneyDonatedPerKilometer * runners * averageLapsPerRunner * trackLength / 1000:f2}");
    }
}