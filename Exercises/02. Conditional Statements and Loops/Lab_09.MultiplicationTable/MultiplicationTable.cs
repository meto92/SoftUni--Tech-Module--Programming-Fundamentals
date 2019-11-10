using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        int integer = int.Parse(Console.ReadLine());

        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
        }
    }
}