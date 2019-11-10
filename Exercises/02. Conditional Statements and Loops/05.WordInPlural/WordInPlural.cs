using System;

class WordInPlural
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        if (word.EndsWith("y"))
        {
            Console.WriteLine($"{word.Substring(0, word.Length - 1)}ies");
        }
        else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
        {
            Console.WriteLine($"{word}es");
        }
        else
        {
            Console.WriteLine($"{word}s");
        }
    }
}