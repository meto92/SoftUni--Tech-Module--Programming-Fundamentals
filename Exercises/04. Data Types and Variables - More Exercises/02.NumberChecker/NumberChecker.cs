using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        try
        {
            long.Parse(Console.ReadLine());
            Console.WriteLine("integer");
        }
        catch (Exception)
        {
            Console.WriteLine($"floating-point");
        }
    }
}