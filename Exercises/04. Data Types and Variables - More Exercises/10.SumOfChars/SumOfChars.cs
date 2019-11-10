using System;

class SumOfChars
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        int sumOfChars = 0;

        for (int i = 0; i < lines; i++)
        {
            sumOfChars += (int)char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The sum equals: {sumOfChars}");
    }
}