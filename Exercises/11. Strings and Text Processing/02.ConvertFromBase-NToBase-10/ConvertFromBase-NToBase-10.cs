using System;
using System.Numerics;

class ConvertFromBaseNToBase10
{
    static BigInteger ConvertToBase10(BigInteger baseN_Number, int baseN)
    {
        BigInteger result = 0;
        string baseN_NumberStr = baseN_Number.ToString();
        int length = baseN_NumberStr.Length;

        for (int i = 0; i < length; i++)
        {
            int digit = int.Parse(baseN_NumberStr[i].ToString());

            BigInteger product = 1;

            for (int k = 0; k < length - i - 1; k++)
            {
                product *= baseN;
            }

            result += digit * product;
        }

        return result;
    }
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int baseN = int.Parse(input[0]);
        BigInteger baseN_Number = BigInteger.Parse(input[1]);

        Console.WriteLine(ConvertToBase10(baseN_Number, baseN));
    }
}