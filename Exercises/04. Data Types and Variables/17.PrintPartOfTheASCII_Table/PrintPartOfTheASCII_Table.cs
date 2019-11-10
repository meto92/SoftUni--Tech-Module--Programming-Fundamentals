using System;

class PrintPartOfTheASCII_Table
{
    static void Main(string[] args)
    {
        char firstChar = (char)int.Parse(Console.ReadLine());
        char lastChar = (char)int.Parse(Console.ReadLine());

        for (char symbol = firstChar; symbol <= lastChar; symbol++)
        {
            Console.Write($"{symbol} ");
        }

        Console.WriteLine();
    }
}