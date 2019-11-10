using System;
using System.Linq;
using System.Collections.Generic;

class ShootListElements
{
    static void Main(string[] args)
    {
        int lastRemovedNumber = -1;
        List<int> numbers = new List<int>();

        string input;

        while ((input = Console.ReadLine()) != "stop")
        {
            if (input == "bang")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastRemovedNumber}");
                    return;
                }

                if (numbers.Count == 1)
                {
                    lastRemovedNumber = numbers[0];
                }
                else
                {
                    lastRemovedNumber = numbers.First(x => x < numbers.Average());
                }

                numbers.Remove(lastRemovedNumber);
                numbers = numbers.Select(x => --x).ToList();

                Console.WriteLine($"shot {lastRemovedNumber}"); 
            }
            else
            {
                int newElement = int.Parse(input);

                numbers.Insert(0, newElement);
            }
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine($"survivors: {string.Join(" ", numbers)}");
        }
        else
        {
            Console.WriteLine($"you shot them all. last one was {lastRemovedNumber}");
        }
    }
}