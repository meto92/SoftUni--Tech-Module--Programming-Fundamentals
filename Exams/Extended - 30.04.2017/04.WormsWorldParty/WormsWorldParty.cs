using System;
using System.Linq;
using System.Collections.Generic;

class WormsWorldParty
{
    static bool IsWormAlreadyInTeam(Dictionary<string, Dictionary<string, long>> wormTeams, string wormName)
    {
        foreach (KeyValuePair<string, Dictionary<string, long>> wormTeam in wormTeams)
        {
            if (wormTeam.Value.ContainsKey(wormName))
            {
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> wormTeams = new Dictionary<string, Dictionary<string, long>>();

        string input;

        while ((input = Console.ReadLine()) != "quit")
        {
            string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string wormName = tokens[0];
            string teamName = tokens[1];
            int wormScore = int.Parse(tokens[2]);

            if (!IsWormAlreadyInTeam(wormTeams, wormName))
            {
                if (!wormTeams.ContainsKey(teamName))
                {
                    wormTeams[teamName] = new Dictionary<string, long>();
                }

                wormTeams[teamName][wormName] = wormScore;
            }
        }

        int teamCounter = 0;

        foreach (KeyValuePair<string, Dictionary<string, long>> wormTeam in wormTeams.OrderByDescending(p => p.Value.Values.Sum()).ThenByDescending(p => p.Value.Values.Average()))
        {
            string teamName = wormTeam.Key;
            long totalScore = wormTeam.Value.Values.Sum();

            Console.WriteLine($"{++teamCounter}. Team: {teamName} - {totalScore}");

            foreach (KeyValuePair<string, long> scoresByWorms in wormTeams[teamName].OrderByDescending(p => p.Value))
            {
                string wormName = scoresByWorms.Key;
                long wormScore = scoresByWorms.Value;

                Console.WriteLine($"###{wormName} : {wormScore}");
            }
        }
    }
}