using System;
using System.Linq;
using System.Collections.Generic;

class HornetAssault
{
    static void Main(string[] args)
    {
        long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

        for (int i = 0; i < beehives.Length && hornets.Any(); i++)
        {
            long hornetsPower = hornets.Sum();
            
            if (beehives[i] >= hornetsPower)
            {
                beehives[i] -= hornetsPower;
                hornets.RemoveAt(0);
            }
            else
            {
                beehives[i] = 0;
            }
        }

        if (beehives.Any(x => x > 0))
        {
            Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
        }
    }
}