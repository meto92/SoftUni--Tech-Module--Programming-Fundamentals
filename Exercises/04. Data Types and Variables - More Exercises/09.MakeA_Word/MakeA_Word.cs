using System;

class MakeA_Word
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        char[] letters = new char[lines];

        for (int i = 0; i < lines; i++)
        {
            letters[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The word is: {string.Join("", letters)}");
    }
}