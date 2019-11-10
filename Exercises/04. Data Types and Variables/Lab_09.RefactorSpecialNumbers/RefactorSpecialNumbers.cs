using System;

class RefactorSpecialNumbers
{
    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        bool isSpecial = false;

        for (int num = 1; num <= lastNumber; num++)
        {
            int currentNumber = num,
                sumOfDigits = 0;

            while (num > 0)
            {
                sumOfDigits += num % 10;
                num = num / 10;
            }

            isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

            Console.WriteLine($"{currentNumber} -> {isSpecial}");

            num = currentNumber;
        }
    }
}