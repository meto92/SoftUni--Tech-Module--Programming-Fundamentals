using System;
using System.Linq;

class PowerPlants
{
    static void Main(string[] args)
    {
        int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int survivedDays = 0,
            seasons = 0;

        while (true)
        {
            for (int day = 0; day < plants.Length && plants.Any(x => x > 0); day++, survivedDays++)
            {
                if (plants[day] > 0)
                {
                    plants[day]++;
                }

                for (int i = 0; i < plants.Length; i++)
                {
                    if (plants[i] > 0)
                    {
                        plants[i]--;
                    }
                }
            }

            if (plants.All(x => x == 0))
            {
                break;
            }
            
            seasons++;

            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i] > 0)
                {
                    plants[i]++;
                }
            }
        }

        Console.WriteLine($"survived {survivedDays} days ({seasons} seasons)");
    }
}