using System;

class WaterOverflow
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        int tankCapacity = 255;

        for (int i = 0; i < lines; i++)
        {
            int litersOfWater = int.Parse(Console.ReadLine());

            if (tankCapacity - litersOfWater >= 0)
            {
                tankCapacity -= litersOfWater;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(255 - tankCapacity);
    }
}