using System;
using System.Linq;

class Ladybugs
{
    static void MoveLadybug(int[] field, int ladybugIndex, string direction, long flyLength)
    {
        field[ladybugIndex] = 0;

        long newPosition = ladybugIndex,
                move = direction == "right" ? flyLength : -flyLength;

        newPosition += move;

        while (newPosition >= 0 && newPosition < field.Length && field[newPosition] != 0)
        {
            newPosition += move;
        }

        if (newPosition >= 0 && newPosition < field.Length)
        {
            field[newPosition] = 1;
        }
    }

    static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] field = new int[fieldSize];

        foreach (int index in indexes)
        {
            if (index >= 0 && index < fieldSize)
            {
                field[index] = 1;
            }
        }

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] items = input.Split();

            int ladybugIndex = int.Parse(items[0]);
            string direction = items[1];
            long flyLength = long.Parse(items[2]);

            if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] == 0)
            {
                continue;
            }

            MoveLadybug(field, ladybugIndex, direction, flyLength);
        }

        Console.WriteLine(string.Join(" ", field));
    }
}