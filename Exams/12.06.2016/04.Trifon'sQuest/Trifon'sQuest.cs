using System;
using System.Linq;

class QuestOfTrifon
{
    static void Main(string[] args)
    {
        long healthPoints = long.Parse(Console.ReadLine());
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = dimensions[0],
            cols = dimensions[1];

        char[][] map = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            map[i] = Console.ReadLine().ToCharArray();
        }

        int row = 0,
            col = 0,
            turns = 0;

        while (col < cols)
        {
            int move = col % 2 == 0 ? 1 : -1;

            while (row >= 0 && row < rows)
            {
                switch (map[row][col])
                {
                    case 'F':
                        healthPoints -= turns / 2;

                        if (healthPoints <= 0)
                        {
                            Console.WriteLine($"Died at: [{row}, {col}]");
                            return;
                        }
                        break;
                    case 'H':
                        healthPoints += turns / 3;
                        break;
                    case 'T':
                        turns += 2;
                        break;
                    case 'E':
                        break;
                }

                turns++;
                row += move;
            }

            row -= move;
            col++;
        }

        Console.WriteLine("Quest completed!");
        Console.WriteLine($"Health: {healthPoints}");
        Console.WriteLine($"Turns: {turns}");
    }
}