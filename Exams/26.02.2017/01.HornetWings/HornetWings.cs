using System;

class HornetWings
{
    static void Main(string[] args)
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distanceFor1000Flaps = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double travelledDistance = distanceFor1000Flaps * wingFlaps / 1000;
        long time = (long)wingFlaps / 100 + 5 * (wingFlaps / endurance);

        Console.WriteLine($"{travelledDistance:f2} m.");
        Console.WriteLine($"{time} s.");
    }
}