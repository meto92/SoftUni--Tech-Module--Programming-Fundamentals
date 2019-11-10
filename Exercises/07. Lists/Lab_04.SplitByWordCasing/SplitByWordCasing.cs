using System;
using System.Linq;
using System.Collections.Generic;

class SplitByWordCasing
{
    enum WordType
    {
        LowerCase, UpperCase, MixedCase
    }

    static WordType GetWordType(string word)
    {
        int lowerCaseLetters = word.Count(x => char.IsLower(x));
        int upperCaseLetters = word.Count(x => char.IsUpper(x));

        if (lowerCaseLetters == word.Length)
        {
            return WordType.LowerCase;
        }
        else if (upperCaseLetters == word.Length)
        {
            return WordType.UpperCase;
        }

        return WordType.MixedCase;
    }

    static void DistributeWords(string[] words, List<string> lowerCaseWords, List<string> upperCaseWords, List<string> mixedCaseWords)
    {
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            WordType type = GetWordType(word);

            if (type == WordType.LowerCase)
            {
                lowerCaseWords.Add(word);
            }
            else if (type == WordType.UpperCase)
            {
                upperCaseWords.Add(word);
            }
            else
            {
                mixedCaseWords.Add(word);
            }
        }
    }

    static void PrintResult(List<string> lowerCaseWords, List<string> upperCaseWords, List<string> mixedCaseWords)
    {
        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
    }

    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(new [] { ' ', ',', '.', ':', ';', '!', '(', ')', '\'', '\"', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> lowerCaseWords = new List<string>();
        List<string> upperCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();

        DistributeWords(words, lowerCaseWords, upperCaseWords, mixedCaseWords);
        PrintResult(lowerCaseWords, upperCaseWords, mixedCaseWords);
    }
}