using System;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.Write($"\\u{Convert.ToString(char.ConvertToUtf32(word, i), 16).PadLeft(4, '0')}");
        }

        Console.WriteLine();
    }
}