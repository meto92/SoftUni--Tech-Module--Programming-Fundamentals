using System;

class PrintingTriangle
{
    static void PrintUpperPart(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            for (int num = 1; num <= row; num++)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }

    static void PrintBottomPart(int n)
    {
        for (int row = n; row > 0; row--)
        {
            for (int num = 1; num <= row; num++)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }

    static void PrintTriangle(int n)
    {
        PrintUpperPart(n);
        PrintBottomPart(n - 1);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }
}