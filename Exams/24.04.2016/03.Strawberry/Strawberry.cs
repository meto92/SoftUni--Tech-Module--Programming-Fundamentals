using System;

class Strawberry
{
    private static int n;
    private static int width;

    static void PrintTop()
    {
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}",
                new string('-', 2 * i), new string('-', (width - 3 - i * 4) / 2));
        }
    }

    static void PrintMiddle()
    {
        Console.WriteLine("{0}#.#{0}", new string('-', n));

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",
                new string('-', n - 2 * i), new string('.', width - 2 - 2 * (n - 2 * i)));
        }
    }

    static void PrintBottom()
    {
        for (int i = 0; i < n + 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",
                new string('-', i), new string('.', width - 2 - 2 * i));
        }
    }

    static void Main(string[] args)
    {
        n = int.Parse(Console.ReadLine());
        width = 2 * n + 3;

        PrintTop();
        PrintMiddle();
        PrintBottom();
    }    
}