using System;
using System.Text.RegularExpressions;

class ExtractSentencesByKeyword
{
    static void Main(string[] args)
    {
        Regex keyWord = new Regex($"\\b{Console.ReadLine()}\\b");
        string[] sentences = Console.ReadLine().Split('.', '!', '?');

        foreach (string sentence in sentences)
        {
            Match match = keyWord.Match(sentence);

            if (match.Success)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}