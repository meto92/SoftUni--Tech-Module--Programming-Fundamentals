using System;
using System.Text.RegularExpressions;

class PhoenixGrid
{
    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        string pattern = @"^[^\s_]{3}(\.[^\s_]{3})*$";
        string input;

        while ((input = Console.ReadLine()) != "ReadMe")
        {
            if (Regex.IsMatch(input, pattern) && IsPalindrome(input))
            {
                    Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}