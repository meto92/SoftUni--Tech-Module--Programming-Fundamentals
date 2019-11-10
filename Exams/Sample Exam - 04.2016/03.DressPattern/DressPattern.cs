using System;

class DressPattern
{
    static void PrintTop(int n, int totalWidth)
    {
        Console.WriteLine("{0}.{0}.{0}", new string('_', 4 * n));

        for (int i = 1; i <= 2 * n; i++)
        {
            Console.WriteLine("{0}.{1}.{0}.{1}.{0}", new string('_', 4 * n - 2 * i), new string('*', (totalWidth - 4 - 3 * (4 * n - 2 * i)) / 2));
        }

        string s = string.Concat(".", new string('*', totalWidth - 2), ".");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("{0}{1}{0}", new string('.', 3 * n), new string('*', totalWidth - 6 * n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('_', 3 * n), new string('o', totalWidth - 6 * n));
        }
    }

    static void PrintBottom(int n, int totalWidth)
    {
        for (int i = 0; i < 3 * n; i++)
        {
            Console.WriteLine("{0}.{1}.{0}", new string('_', 3 * n - i), new string('*', totalWidth - 2 * (3 * n - i + 1)));
        }

        Console.WriteLine(new string('.', totalWidth));
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int totalWidth = 12 * n + 2;

        PrintTop(n, totalWidth);
        PrintBottom(n, totalWidth);
    }
}