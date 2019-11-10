using System;

class ReverseCharacters
{
    static void Main(string[] args)
    {
        char[] letters = new char[3];

        for (int i = 2; i >= 0; i--)
        {
            letters[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join("", letters));
    }
}