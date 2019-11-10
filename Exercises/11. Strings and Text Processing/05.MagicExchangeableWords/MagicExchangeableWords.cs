using System;
using System.Linq;

class MagicExchangeableWords
{
    static bool AreExchangable(string word1, string word2)
    {
        if (word1.Distinct().ToArray().Length != word2.Distinct().ToArray().Length)
        {
            return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        Console.WriteLine(AreExchangable(words[0], words[1]).ToString().ToLower());
    }
}