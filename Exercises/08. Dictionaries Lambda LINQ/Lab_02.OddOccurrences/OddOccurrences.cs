using System;
using System.Linq;
using System.Collections.Generic;

class OddOccurrences
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ').Select(s => s.ToLower()).ToArray();

        Dictionary<string, int> wordsOccurrences = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            if (!wordsOccurrences.ContainsKey(word))
            {
                wordsOccurrences[word] = 0;
            }

            wordsOccurrences[word]++;
        }

        Console.WriteLine(string.Join(", ", wordsOccurrences.Where(p => p.Value % 2 != 0).ToDictionary(k => k.Key, v => v.Value).Keys));
    }
}