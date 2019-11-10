using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCount
{
    static void Main(string[] args)
    {
        Dictionary<string, int> wordsOccurrences = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("../../words.txt"))
        {
            string[] words = reader.ReadLine().ToLower().Split(' ');

            foreach (string word in words)
            {
                wordsOccurrences[word] = 0;
            }
        }

        using (StreamReader reader = new StreamReader("../../text.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.ToLower().Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '-', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string word in words)
                {
                    if (wordsOccurrences.ContainsKey(word))
                    {
                        wordsOccurrences[word]++;
                    }
                }
            }
        }

        using (StreamWriter writer = new StreamWriter("../../Output.txt"))
        {
            writer.WriteLine(string.Join(Environment.NewLine, wordsOccurrences.OrderByDescending(p => p.Value).Select(p => $"{p.Key} - {p.Value}")));
        }
    }
}