using System;

class SpecialNumbers
{
    static bool IsSpecial(int num)
    {
        int sumOfDigits = 0;

        while (num > 0)
        {
            sumOfDigits += num % 10;
            num /= 10;
        }

        if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        for (int num = 1; num <= lastNumber; num++)
        {
            Console.WriteLine($"{num} -> {IsSpecial(num)}");
        }
    }
}