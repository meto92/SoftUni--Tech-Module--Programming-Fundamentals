using System;

class LettersChangeNumbers
{
    static double CalcStringValue(string str)
    {
        char leftLetter = str[0];
        char rightLetter = str[str.Length - 1];

        int leftLetterPosition = char.ToUpper(leftLetter) - 64;
        int rightLetterPosition = char.ToUpper(rightLetter) - 64;

        double result = double.Parse(str.Substring(1, str.Length - 2));

        if (char.IsUpper(leftLetter))
        {
            result /= leftLetterPosition;
        }
        else
        {
            result *= leftLetterPosition;
        }

        if (char.IsUpper(rightLetter))
        {
            result -= rightLetterPosition;
        }
        else
        {
            result += rightLetterPosition;
        }

        return result;
    }

    static void Main(string[] args)
    {
        string[] strings = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            sum += CalcStringValue(strings[i]);
        }

        Console.WriteLine($"{sum:f2}");
    }
}