using System;
using System.Numerics;

class BigFactorial
{
    static BigInteger CalcFactorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CalcFactorial(int.Parse(Console.ReadLine())));
    }
}