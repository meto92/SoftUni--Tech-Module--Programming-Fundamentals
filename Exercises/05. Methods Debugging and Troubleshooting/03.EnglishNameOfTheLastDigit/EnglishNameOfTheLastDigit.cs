using System;

class EnglishNameOfTheLastDigit
{
    static string GetLastDigitName(long num)
    {
        long lastDigit = Math.Abs(num) % 10;

        switch (lastDigit)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "zero";
        }
    }

    static void Main(string[] args)
    {
        long num = long.Parse(Console.ReadLine());
        
        string lastDigitName = GetLastDigitName(num);

        Console.WriteLine(lastDigitName);
    }
}