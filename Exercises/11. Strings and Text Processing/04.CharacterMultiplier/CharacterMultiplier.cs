using System;
using System.Linq;

class CharacterMultiplier
{
    static int MultiplyChars(string word1, string word2)
    {
        int sum = 0;
        int shorterWordLength = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < shorterWordLength; i++)
        {
            sum += word1[i] * word2[i];
        }

        if (word1.Length > shorterWordLength)
        {
            sum += new string(word1.Skip(shorterWordLength).Take(word1.Length).ToArray()).Sum(x => x);
        }
        else if (word2.Length > shorterWordLength)
        {
            sum += new string(word2.Skip(shorterWordLength).Take(word2.Length).ToArray()).Sum(x => x);
        }

        return sum;
    }

    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        Console.WriteLine(MultiplyChars(words[0], words[1]));
    }
}