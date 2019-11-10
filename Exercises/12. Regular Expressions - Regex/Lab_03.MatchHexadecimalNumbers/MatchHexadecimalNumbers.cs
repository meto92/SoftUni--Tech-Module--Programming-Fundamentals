using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchHexadecimalNumbers
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"\b(0x)?[\dA-F]+\b");

        string numbersString = Console.ReadLine();

        Console.WriteLine(string.Join(" ",
            pattern.Matches(numbersString).Cast<Match>().Select(m => m.Value)));
    }
}