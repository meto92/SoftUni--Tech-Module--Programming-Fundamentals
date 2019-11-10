using System;

class MasterNumbers
{
    static bool IsPalindrome(int num)
    {
        string numString = num.ToString();

        for (int i = 0; i < numString.Length / 2; i++)
        {
            if (numString[i] != numString[numString.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static bool IsSumOfDigitsDivisibleBy7(int num)
    {
        int sumOfDigits = 0;

        while (num > 0)
        {
            sumOfDigits += num % 10;
            num /= 10;
        }

        return sumOfDigits % 7 == 0;
    }

    static bool ContainsEvenDigit(int num)
    {
        while (num > 0)
        {
            int digit = num % 10;
            
            if (digit %2 == 0)
            {
                return true;
            }

            num /= 10;
        }

        return false;
    }

    static void Main(string[] args)
    {
        int lastNum = int.Parse(Console.ReadLine());
        
        for (int num = 1; num <= lastNum; num++)
        {
            if (IsPalindrome(num) && IsSumOfDigitsDivisibleBy7(num) && ContainsEvenDigit(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}