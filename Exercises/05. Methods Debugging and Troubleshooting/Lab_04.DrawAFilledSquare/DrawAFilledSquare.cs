using System;

class DrawA_FilledSquare
{
    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddleRows(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");

            for (int j = 0; j < n - 1; j++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }

    static void DrawSquare(int n)
    {
        PrintHeaderRow(n);

        PrintMiddleRows(n);

        PrintHeaderRow(n);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        DrawSquare(n);
    }
}