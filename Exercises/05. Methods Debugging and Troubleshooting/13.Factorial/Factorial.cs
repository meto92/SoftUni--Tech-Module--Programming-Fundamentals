using System;
using System.Numerics;

class Factorial
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
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = CalcFactorial(n);

        Console.WriteLine(factorial);
    }
}