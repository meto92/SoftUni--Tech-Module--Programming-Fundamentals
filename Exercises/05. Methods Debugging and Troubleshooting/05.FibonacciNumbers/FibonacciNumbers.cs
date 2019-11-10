using System;

class FibonacciNumbers
{
    static long Fib(int n)
    {
        long fib1 = 0;
        long fib2 = 0;
        long fib = 1;

        for (int i = 0; i < n; i++)
        {
            fib1 = fib2;
            fib2 = fib;
            fib = fib1 + fib2;
        }

        return fib;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Fib(n));
    }
}