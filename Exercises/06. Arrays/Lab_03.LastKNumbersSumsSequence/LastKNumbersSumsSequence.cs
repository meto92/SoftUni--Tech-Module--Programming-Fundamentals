using System;

class LastK_NumbersSumsSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] sequence = new long[n];

        sequence[0] = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = i - 1; j >= i - k && j >= 0; j--)
            {
                sequence[i] += sequence[j];
            }
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}