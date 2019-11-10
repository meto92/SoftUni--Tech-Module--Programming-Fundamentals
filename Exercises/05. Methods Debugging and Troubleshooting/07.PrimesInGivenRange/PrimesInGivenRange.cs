using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static bool[] AreNotPrimes;

    static void SetPrimes(int num)
    {
        for (int i = 2 * num; i < AreNotPrimes.Length; i += num)
        {
            AreNotPrimes[i] = true;
        }
    }

    static void AddPrimes(List<int> primes, int startNum, int endNum)
    {
        if (startNum < 0)
        {
            startNum = 2;
        }

        for (int i = startNum; i <= endNum; i++)
        {
            if (!AreNotPrimes[i])
            {
                primes.Add(i);
            }
        }
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        if (endNum < 1)
        {
            endNum = 1;
        }

        AreNotPrimes = new bool[endNum + 1];

        AreNotPrimes[0] = true;
        AreNotPrimes[1] = true;

        for (int num = 2; num <= endNum / 2; num++)
        {
            SetPrimes(num);
        }

        List<int> primes = new List<int>();

        AddPrimes(primes, startNum, endNum);

        return primes;
    }

    static void PrintPrimes(List<int> primes)
    {
        Console.WriteLine(string.Join(", ", primes));
    }

    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> primes = FindPrimesInRange(startNum, endNum);

        PrintPrimes(primes);
    }
}