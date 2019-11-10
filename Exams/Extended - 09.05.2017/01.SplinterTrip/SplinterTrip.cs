using System;

class SplinterTrip
{
    static void Main(string[] args)
    {
        double tripDistanceInMiles = double.Parse(Console.ReadLine());
        double tankFuelInLiters = double.Parse(Console.ReadLine());
        double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

        const double fuelSpentPerMile = 25;
        const double fuelSpentInHeavyWindsPerMile = fuelSpentPerMile * 1.5;

        double totalFuelNeeded = 0;

        totalFuelNeeded += (tripDistanceInMiles - milesSpentInHeavyWinds) * fuelSpentPerMile;
        totalFuelNeeded += milesSpentInHeavyWinds * fuelSpentInHeavyWindsPerMile;
        totalFuelNeeded *= 1.05;

        Console.WriteLine($"Fuel needed: {totalFuelNeeded:f2}L");

        if (totalFuelNeeded <= tankFuelInLiters)
        {
            double remainingFuel = tankFuelInLiters - totalFuelNeeded;

            Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
        }
        else
        {
            double fuelNeeded = totalFuelNeeded - tankFuelInLiters;

            Console.WriteLine($"We need {fuelNeeded:f2}L more fuel.");
        }
    }
}