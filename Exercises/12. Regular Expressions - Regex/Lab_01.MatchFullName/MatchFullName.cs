using System;
using System.Text.RegularExpressions;

class MatchFullName
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        string names = Console.ReadLine();

        foreach (Match name in pattern.Matches(names))
        {
            Console.Write($"{name} ");
        }

        Console.WriteLine();
    }
}