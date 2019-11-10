using System;

class GameOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());

        int firstNum = 0,
            secondNum = 0,
            combinations = 0;

        int start = Math.Min(n, m),
            end = Math.Max(n, m);

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                combinations++;

                if (i + j == magicalNumber)
                {
                    firstNum = i;
                    secondNum = j;                        
                }
            }
        }

        if (firstNum != 0)
        {
            Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicalNumber}");
        }
        else
        {
            Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
        }
    }
}