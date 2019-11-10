using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {        
        string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.TrimEnd('.', '!', '?', ',', ':', ';')).ToArray();

        Regex emailPattern = new Regex(@"(?<user>[a-zA-Z\d]+((\.|-|_)[a-zA-Z\d]+)*)@(?<host>([a-zA-Z]+(-?[a-zA-Z]+)*)(\.([a-zA-Z]+(-?[a-zA-Z]+)*))+)");

        foreach (string word in words)
        {
            Match match = emailPattern.Match(word);

            if (match.Success && word == match.Groups[0].Value)
            {
                Console.WriteLine(word);
            }
        }
    }
}