using System;
using System.Collections.Generic;

class StringConcatenation
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        bool isEven = Console.ReadLine() == "even";
        int lines = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 1; i <= lines; i++)
        {
            string word = Console.ReadLine();

            if (isEven && i %2 == 0)
            {
                words.Add(word);
            }
            else if (!isEven && i % 2 != 0)
            {
                words.Add(word);
            }
        }

        Console.WriteLine(string.Join(delimiter, words));
    }
}