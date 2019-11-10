using System;
using System.Numerics;
using System.Collections.Generic;

class ConvertFromBase10ToBaseN
{
    static string ConvertToBaseN(BigInteger number, int baseN)
    {
        Stack<BigInteger> result = new Stack<BigInteger>();

        while (number > 0)
        {
            result.Push(number % baseN);
            number /= baseN;
        }

        return string.Join("", result); ;
    }

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int baseN = int.Parse(input[0]);
        BigInteger base10Number = BigInteger.Parse(input[1]);

        Console.WriteLine(ConvertToBaseN(base10Number, baseN));
    }
}