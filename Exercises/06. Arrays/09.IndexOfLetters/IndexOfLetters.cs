using System;
using System.Collections.Generic;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        Dictionary<char, int> charsIndices = new Dictionary<char, int>();

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            charsIndices[letter] = letter - 'a';
        }

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine($"{word[i]} -> {charsIndices[word[i]]}");
        }
    }
}