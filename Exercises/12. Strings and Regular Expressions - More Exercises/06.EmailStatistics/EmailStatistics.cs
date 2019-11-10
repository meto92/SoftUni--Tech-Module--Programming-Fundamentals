using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class EmailStatistics
{
    static void Main(string[] args)
    {
        int emailsCount = int.Parse(Console.ReadLine());

        Regex pattern = new Regex(@"^(?<username>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}\.(com|bg|org))$");

        Dictionary<string, List<string>> usernamesByDomains = new Dictionary<string, List<string>>();

        for (int i = 0; i < emailsCount; i++)
        {
            string input = Console.ReadLine();

            Match email = pattern.Match(input);

            if (!email.Success)
            {
                continue;
            }

            string username = email.Groups["username"].Value;
            string domain = email.Groups["domain"].Value;

            if (!usernamesByDomains.ContainsKey(domain))
            {
                usernamesByDomains[domain] = new List<string>();
            }

            if (!usernamesByDomains[domain].Contains(username))
            {
                usernamesByDomains[domain].Add(username);
            }
        }

        foreach (KeyValuePair<string, List<string>> pair in usernamesByDomains.OrderByDescending(p => usernamesByDomains[p.Key].Count))
        {
            string domain = pair.Key;

            Console.WriteLine($"{domain}:");
            Console.WriteLine(string.Join(Environment.NewLine,
                usernamesByDomains[domain].Select(u => $"### {u}")));
        }
    }
}