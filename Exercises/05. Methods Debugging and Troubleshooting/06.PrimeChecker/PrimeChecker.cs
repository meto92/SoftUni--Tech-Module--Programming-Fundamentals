using System;

class PrimeChecker
{
    static bool IsPrime(long num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
        {
            if (num % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        long num = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(num);

        Console.WriteLine(isPrime);
    }
}