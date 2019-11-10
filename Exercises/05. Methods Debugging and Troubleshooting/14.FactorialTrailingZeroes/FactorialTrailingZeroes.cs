using System;
using System.Numerics;

class FactorialTrailingZeroes
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

    static int CountTrailingZeroes(BigInteger factorial)
    {
        int length = factorial.ToString().Length;
        int lengthWithoutTrailingZeroes = factorial.ToString().TrimEnd('0').Length;

        return length - lengthWithoutTrailingZeroes;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = CalcFactorial(n);

        int trailingZeroes = CountTrailingZeroes(factorial);

        Console.WriteLine(trailingZeroes);
    }
}