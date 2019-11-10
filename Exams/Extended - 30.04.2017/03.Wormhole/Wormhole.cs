using System;
using System.Linq;

class Wormhole
{
    static void Main(string[] args)
    {
        int[] wormHoles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int steps = 0,
            index = 0;

        while (index < wormHoles.Length)
        {
            if (wormHoles[index] == 0)
            {
                index++;
                steps++;
            }
            else
            {
                int newPosition = wormHoles[index];

                wormHoles[index] = 0;
                index = newPosition;
            }
        }

        Console.WriteLine(steps);
    }
}