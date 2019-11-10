using System;

class SignOfIntegerNumber
{
    static void PrintSign(int number)
    {
        string sign;

        if (number > 0)
        {
            sign = "positive";
        }
        else if (number < 0)
        {
            sign = "negative";
        }
        else
        {
            sign = "zero";
        }

        Console.WriteLine($"The number {number} is {sign}.");
    }

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        PrintSign(num);
    }
}