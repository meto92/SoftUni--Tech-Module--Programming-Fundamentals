using System;
using System.Text.RegularExpressions;

class Regexmon
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        Regex patternOfDidimon = new Regex(@"[^a-zA-Z-]+");
        Regex patternOfBojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

        int turn = 0,
            index = 0;

        while (true)
        {
            str = str.Substring(index);

            Match match;

            if (turn == 0)
            {
                match = patternOfDidimon.Match(str);
            }
            else
            {
                match = patternOfBojomon.Match(str);
            }

            if (!match.Success)
            {
                break;
            }

            Console.WriteLine(match);

            index = match.Index;
            turn ^= 1;
        }
    }
}