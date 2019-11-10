using System;
using System.Linq;
using System.Collections.Generic;

class ArrayHistogram
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();

        Dictionary<string, int> wordsOccurrences = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordsOccurrences.ContainsKey(word))
            {
                wordsOccurrences[word] = 0;
            }

            wordsOccurrences[word]++;
        }

        foreach (KeyValuePair<string, int> pair in wordsOccurrences.OrderByDescending(p => p.Value))
        {
            string word = pair.Key;
            int occurrences = pair.Value;
            double percentage = (double)occurrences / words.Length * 100;

            Console.WriteLine($"{word} -> {occurrences} times ({percentage:f2}%)");
        }
    }
}