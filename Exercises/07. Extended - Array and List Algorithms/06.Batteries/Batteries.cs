using System;
using System.Linq;

class Batteries
{
    static void Main(string[] args)
    {
        double[] mAhBatteriesCapacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] batteriesUsagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int testHours = int.Parse(Console.ReadLine());

        for (int i = 0; i < batteriesUsagePerHour.Length; i++)
        {
            double leftBatteryCapacity = mAhBatteriesCapacity[i];
            double batteryUsagePerHour = batteriesUsagePerHour[i];

            int hours = 0;

            for (; hours < testHours && leftBatteryCapacity > 0; hours++)
            {
                leftBatteryCapacity -= batteryUsagePerHour;
            }

            Console.Write($"Battery {i + 1}: ");

            if (leftBatteryCapacity <= 0)
            {
                Console.WriteLine($"dead (lasted {hours} hours)");
            }
            else
            {
                double leftCapacityPercentage = leftBatteryCapacity / mAhBatteriesCapacity[i] * 100;

                Console.WriteLine($"{leftBatteryCapacity:f2} mAh ({leftCapacityPercentage:f2})%");
            }
        }
    }
}