using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SrubskoUnleashed
{
    static void ReadAndProcessInput(Dictionary<string, Dictionary<string, int>> venuesInfo)
    {
        Regex pattern = new Regex(@"(?<singer>[a-zA-Z]+( [a-zA-Z]+)*) @(?<venue>[a-zA-Z ]+) (?<ticketsPrice>\d+) (?<ticketsCount>\d+)");

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            Match match = pattern.Match(input);

            if (!match.Success)
            {
                continue;
            }

            string venue = match.Groups["venue"].Value;
            string singer = match.Groups["singer"].Value;
            int ticketsPrice = int.Parse(match.Groups["ticketsPrice"].Value);
            int ticketsCount = int.Parse(match.Groups["ticketsCount"].Value);

            if (!venuesInfo.ContainsKey(venue))
            {
                venuesInfo[venue] = new Dictionary<string, int>();
            }

            if (!venuesInfo[venue].ContainsKey(singer))
            {
                venuesInfo[venue][singer] = 0;
            }

            venuesInfo[venue][singer] += ticketsCount * ticketsPrice;
        }
    }

    static void PrintResult(Dictionary<string, Dictionary<string, int>> venuesInfo)
    {
        foreach (KeyValuePair<string, Dictionary<string, int>> pair in venuesInfo)
        {
            string venue = pair.Key;

            Console.WriteLine(venue);

            foreach (KeyValuePair<string, int> p in venuesInfo[venue].OrderByDescending(x => venuesInfo[venue][x.Key]))
            {
                string singer = p.Key;
                int money = venuesInfo[venue][singer];

                Console.WriteLine($"#  {singer} -> {money}");
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> venuesInfo = new Dictionary<string, Dictionary<string, int>>();

        ReadAndProcessInput(venuesInfo);
        PrintResult(venuesInfo);
    }
}