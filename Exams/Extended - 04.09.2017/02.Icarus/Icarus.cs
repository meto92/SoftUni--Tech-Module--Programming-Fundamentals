using System;
using System.Linq;

class Icarus
{
    static void BurnToLeft(int[] plane, int steps, ref int position, ref int damage)
    {
        position--;

        for (int i = 0; i < steps; i++)
        {
            if (position == -1)
            {
                position = plane.Length - 1;
                damage++;
            }

            plane[position] -= damage;
            position--;
        }

        position++;
    }

    static void BurnToRight(int[] plane, int steps, ref int position, ref int damage)
    {
        position++;

        for (int i = 0; i < steps; i++)
        {
            if (position == plane.Length)
            {
                position = 0;
                damage++;
            }

            plane[position] -= damage;
            position++;
        }

        position--;
    }

    static void Main(string[] args)
    {
        int[] plane = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int position = int.Parse(Console.ReadLine());

        int damage = 1;

        string input;

        while ((input = Console.ReadLine()) != "Supernova")
        {
            string[] inputParams = input.Split(' ');

            string direction = inputParams[0];
            int steps = int.Parse(inputParams[1]);

            if (direction == "left")
            {
                BurnToLeft(plane, steps, ref position, ref damage);
            }
            else if (direction == "right")
            {
                BurnToRight(plane, steps, ref position, ref damage);
            }
        }

        Console.WriteLine(string.Join(" ", plane));
    }
}