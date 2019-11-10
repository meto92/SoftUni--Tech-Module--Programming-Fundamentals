using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WormIpsum
{
    static Dictionary<char, int> GetCharsCount(string word)
    {
        Dictionary<char, int> charsCount = new Dictionary<char, int>();

        for (int i = 0; i < word.Length; i++)
        {
            char ch = word[i];

            if (!charsCount.ContainsKey(ch))
            {
                charsCount[ch] = 0;
            }

            charsCount[ch]++;
        }

        return charsCount;
    }

    static void Main(string[] args)
    {
        Regex sentencePattern = new Regex(@"[A-Z].*?(?=\.)");

        string input;

        while ((input = Console.ReadLine()) != "Worm Ipsum")
        {
            MatchCollection sentences = sentencePattern.Matches(input);

            if (sentences.Count == 1)
            {
                string sentence = sentences[0].Groups[0].Value;

                MatchCollection words = Regex.Matches(sentence, @"\w+");

                foreach (Match matchedWord in words)
                {
                    string word = matchedWord.Value;

                    Dictionary<char, int> charsCount = GetCharsCount(word);

                    KeyValuePair<char, int> pair = charsCount.OrderByDescending(p => p.Value).First();

                    if (pair.Value > 1)
                    {
                        sentence = sentence.Replace(word, new string(pair.Key, word.Length));
                    }
                }

                Console.WriteLine($"{sentence}.");
            }
        }
    }
}