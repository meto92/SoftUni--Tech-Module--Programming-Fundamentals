using System;
using System.Linq;
using System.Text.RegularExpressions;

class MorseCodeUpgraded
{
    static char GetChar(string code, Regex pattern)
    {
        int zeroesCount = code.Count(c => c == '0');
        int sum = 3 * zeroesCount + 5 * (code.Length - zeroesCount);

        foreach (Match m in pattern.Matches(code))
        {
            sum += m.Length;
        }

        return (char)sum;
    }

    static void Main(string[] args)
    {
        string[] codes = Console.ReadLine().Split('|');

        Regex pattern = new Regex(@"(0|1)\1+");

        string result = string.Empty;

        foreach (string code in codes)
        {
            result += GetChar(code, pattern);    
        }

        Console.WriteLine(result);
    }
}