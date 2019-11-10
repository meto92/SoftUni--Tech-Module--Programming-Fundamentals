using System;

class MultiplyEvensByOdds
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void GetOddsAndEvensSums(int number, out int oddDigitsSum, out int evenDigitsSum)
    {
        int oddsSum = 0,
            evensSum = 0;

        while (number > 0)
        {
            int digit = number % 10;

            if (IsEven(digit))
            {
                evensSum += digit;
            }
            else
            {
                oddsSum += digit;
            }

            number /= 10;
        }

        oddDigitsSum = oddsSum;
        evenDigitsSum = evensSum;
    }

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int oddDigitsSum, evenDigitsSum;

        GetOddsAndEvensSums(Math.Abs(number), out oddDigitsSum, out evenDigitsSum);

        int product = oddDigitsSum * evenDigitsSum;

        Console.WriteLine(product);
    }
}