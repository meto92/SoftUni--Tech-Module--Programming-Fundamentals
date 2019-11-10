using System;

class TestNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int maxSum = int.Parse(Console.ReadLine());

        int combinations = 0,
            sum = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                combinations++;

                int number = 3 * i * j;

                sum += number;

                if (sum >= maxSum)
                {
                    Console.WriteLine($"{combinations} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSum}");

                    return;
                }
            }
        }

        Console.WriteLine($"{combinations} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}