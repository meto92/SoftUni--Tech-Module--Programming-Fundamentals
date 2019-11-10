using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class KarateStrings
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"(?<=>)\d");

        string str = Console.ReadLine();

        StringBuilder result = new StringBuilder(str);

        MatchCollection matches = pattern.Matches(str);

        int prevStrengthLeft = 0;

        foreach (Match match in matches)
        {
            int strength = int.Parse(match.Value);
            int totalStrength = strength + prevStrengthLeft;
            
            int startIndex = match.Index;
            int endIndex = startIndex + totalStrength <= str.Length ? startIndex + totalStrength : str.Length;

            for (int i = startIndex, leftStrength = totalStrength; i < endIndex; i++, leftStrength--)
            {
                if (result[i] == '>')
                {
                    prevStrengthLeft = leftStrength;
                    break;
                }
                else
                {
                    result[i] = '\0';
                }
            }
        }

        Console.WriteLine(new string(result.ToString().Where(c => c != '\0').ToArray()));
    }
}