using System;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main(string[] args)
    {
        string[] forbiddenWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (string forbiddenWord in forbiddenWords)
        {
            text = Regex.Replace(text, forbiddenWord, new string('*', forbiddenWord.Length));
        }

        Console.WriteLine(text);
    }
}