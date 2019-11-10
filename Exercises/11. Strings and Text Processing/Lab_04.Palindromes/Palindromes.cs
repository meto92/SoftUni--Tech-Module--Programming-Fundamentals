using System;
using System.Linq;

class Palindromes
{
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ",
            Console.ReadLine().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).
            Distinct().
            Where(IsPalindrome).
            OrderBy(word => word)));
    }
}