using System;

class FastPrimeChecker_Refactor
{
    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        for (int num = 2; num <= lastNumber; num++)
        {
            bool isPrime = true;

            for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
            {
                if (num % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"{num} -> {isPrime}");
        }
    }
}