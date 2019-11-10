using System;
using System.Linq;

class EnduranceRally
{
    static void Main(string[] args)
    {
        string[] drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        double[] zonesFuel = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x >= 0 && x < zonesFuel.Length).ToArray();

        int driversCount = drivers.Length;

        if (driversCount == 0)
        {
            return;
        }

        double[] driversFuel = drivers.Select(driver => (double)driver[0]).ToArray();
        int[] driversReachedPositions = new int[driversCount];
        bool[] finished = new bool[driversCount].Select(x => true).ToArray();

        for (int zoneIndex = 0; zoneIndex < zonesFuel.Length; zoneIndex++)
        {
            if (!checkpoints.Contains(zoneIndex))
            {
                zonesFuel[zoneIndex] *= -1;
            }

            for (int driverIndex = 0; driverIndex < driversCount; driverIndex++)
            {
                if (!finished[driverIndex])
                {
                    continue;
                }

                driversFuel[driverIndex] += zonesFuel[zoneIndex];
                driversReachedPositions[driverIndex] = zoneIndex;
                
                if (driversFuel[driverIndex] <= 0)
                {
                    finished[driverIndex] = false;
                }
            }
        }

        for (int i = 0; i < driversCount; i++)
        {
            string driver = drivers[i];
            double fuel = driversFuel[i];

            if (finished[i])
            {
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }
            else
            {
                Console.WriteLine($"{driver} - reached {driversReachedPositions[i]}");
            }
        }
    }
}