using System;

class Raindrops
{
    static void Main(string[] args)
    {
        int regionsCount = int.Parse(Console.ReadLine());
        double density = double.Parse(Console.ReadLine());

        double regionalCoefficientsSum = 0;

        for (int i = 0; i < regionsCount; i++)
        {
            string[] items = Console.ReadLine().Split(' ');

            long raindropsCount = long.Parse(items[0]);
            int squareMeters = int.Parse(items[1]);

            double regionalCoefficient = (double)raindropsCount / squareMeters;

            regionalCoefficientsSum += regionalCoefficient;
        }

        if (density != 0)
        {
            Console.WriteLine($"{regionalCoefficientsSum / density:f3}");
        }
        else
        {
            Console.WriteLine($"{regionalCoefficientsSum:f3}");
        }
    }
}