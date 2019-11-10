using System;
using System.Text.RegularExpressions;

class Censorship
{
    static void Main(string[] args)
    {
        string censorWord = Console.ReadLine();
        string sentenceToCensor = Console.ReadLine();

        Console.WriteLine(Regex.Replace(sentenceToCensor, censorWord, new string('*', censorWord.Length)));
    }
}