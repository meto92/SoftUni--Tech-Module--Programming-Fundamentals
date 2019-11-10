using System;

class OddNumber
{
    static void Main(string[] args)
    {
        int number;

        while ((number = int.Parse(Console.ReadLine())) % 2 ==0)
        {
            Console.WriteLine("Please write an odd number.");
        }

        Console.WriteLine($"The number is: {number}");
    }
}