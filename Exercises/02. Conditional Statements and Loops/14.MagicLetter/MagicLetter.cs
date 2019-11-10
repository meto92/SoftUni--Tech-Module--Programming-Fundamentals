using System;

class MagicLetter
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char lastLetter = char.Parse(Console.ReadLine());
        char forbiddenLetter = char.Parse(Console.ReadLine());

        for (char letter1 = firstLetter; letter1 <= lastLetter; letter1++)
        {
            for (char letter2 = firstLetter; letter2 <= lastLetter; letter2++)
            {
                for (char letter3 = firstLetter; letter3 <= lastLetter; letter3++)
                {
                    if (letter1 != forbiddenLetter && letter2 != forbiddenLetter && letter3 != forbiddenLetter)
                    {
                        Console.Write($"{letter1}{letter2}{letter3} ");
                    }
                }
            }
        }

        Console.WriteLine();
    }
}