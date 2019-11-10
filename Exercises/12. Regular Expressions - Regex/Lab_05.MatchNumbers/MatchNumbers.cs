using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchNumbers
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

        string numbersString = Console.ReadLine();

        MatchCollection numbers = pattern.Matches(numbersString);

        Console.WriteLine(string.Join(" ", numbers.Cast<Match>().Select(number => number.Value)));
    }
}