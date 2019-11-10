using System;

class SieveOfEratosthenes
{
    static void SetNotPrimes(bool[] primes, int num)
    {
        for (int pos = 2 * num; pos < primes.Length; pos+=num)
        {
            primes[pos] = false;
        }
    }

    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        if (lastNumber < 2)
        {
            return;
        }

        bool[] primes = new bool[lastNumber + 1];

        primes[0] = primes[1] = false;

        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        for (int num = 2; num <= lastNumber; num++)
        {
            if (primes[num])
            {
                Console.Write($"{num} ");

                SetNotPrimes(primes, num);
            }
        }

        Console.WriteLine();
    }
}