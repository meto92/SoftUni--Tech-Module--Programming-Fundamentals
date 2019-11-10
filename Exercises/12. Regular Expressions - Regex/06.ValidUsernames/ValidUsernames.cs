using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        
        Regex pattern = new Regex(@"^([a-zA-Z])([\w+\-]){2,24}$");
        List<string> validUsernames = new List<string>();

        foreach (string username in usernames)
        {
            Match match = pattern.Match(username);

            if (match.Success)
            {
                validUsernames.Add(username);
            }
        }

        int index = 0,
            bestLength = 0;

        for (int i = 0; i < validUsernames.Count - 1; i++)
        {
            int currentLength = validUsernames[i].Length + validUsernames[i + 1].Length;

            if (currentLength > bestLength)
            {
                index = i;
                bestLength = currentLength;
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, validUsernames.Skip(index).Take(2)));
    }
}