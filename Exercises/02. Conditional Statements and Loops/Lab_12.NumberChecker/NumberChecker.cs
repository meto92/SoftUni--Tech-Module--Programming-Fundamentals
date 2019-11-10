using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        double number;

        if (double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("It is a number.");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}