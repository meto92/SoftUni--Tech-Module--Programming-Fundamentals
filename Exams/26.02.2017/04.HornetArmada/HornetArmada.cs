using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Legion
{
    public string LegionName { get; set; }
    public int LastActivity { get; set; }
    public Dictionary<string, long> Soldiers { get; set; }

    public Legion(string legionName)
    {
       LegionName = legionName;
        Soldiers = new Dictionary<string, long>();
    }
}

class HornetArmada
{
    static void AddLegion(Dictionary<string, Legion> legions, string legionName, string soldierType, int soldiersCount, int lastActivity)
    {
        if (!legions.ContainsKey(legionName))
        {
            legions[legionName] = new Legion(legionName);
        }

        if (!legions[legionName].Soldiers.ContainsKey(soldierType))
        {
            legions[legionName].Soldiers[soldierType] = 0;
        }

        legions[legionName].Soldiers[soldierType] += soldiersCount;

        if (legions[legionName].LastActivity < lastActivity)
        {
            legions[legionName].LastActivity = lastActivity;
        }
    }

    static void PrintResult(Dictionary<string, Legion> legions, Match outputMatch, string soldiersType)
    {
        if (outputMatch.Groups[2].Value == string.Empty)
        {
            foreach (KeyValuePair<string, Legion> legion in legions.Where(p => legions[p.Key].Soldiers.ContainsKey(soldiersType)).OrderByDescending(p => legions[p.Key].LastActivity))
            {
                string legionName = legion.Key;
                int lastActivity = legions[legionName].LastActivity;

                Console.WriteLine($"{lastActivity} : {legionName}");
            }
        }
        else
        {
            int maxActivity = int.Parse(outputMatch.Groups[2].Value);

            foreach (KeyValuePair<string, Legion> legion in legions.Where(p => legions[p.Key].LastActivity < maxActivity && legions[p.Key].Soldiers.ContainsKey(soldiersType)).OrderByDescending(p => legions[p.Key].Soldiers[soldiersType]))
            {
                string legionName = legion.Key;
                long soldiersCount = legions[legionName].Soldiers[soldiersType];

                Console.WriteLine($"{legionName} -> {soldiersCount}");
            }
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Regex pattern = new Regex(@"(\d+) = ([^=->: ]+) -> ([^=->: ]+):(\d+)");

        Dictionary<string, Legion> legions = new Dictionary<string, Legion>();

        for (int i = 0; i < n; i++)
        {
            Match legionInfo = pattern.Match(Console.ReadLine());

            int lastActivity = int.Parse(legionInfo.Groups[1].Value);
            string legionName = legionInfo.Groups[2].Value;
            string soldierType = legionInfo.Groups[3].Value;
            int soldiersCount = int.Parse(legionInfo.Groups[4].Value);

            AddLegion(legions, legionName, soldierType, soldiersCount, lastActivity);
        }

        Regex outputPattern = new Regex(@"((\d+)\\)?([^=->: ]+)");

        string query = Console.ReadLine();

        Match outputMatch = outputPattern.Match(query);

        string soldiersType = outputMatch.Groups[3].Value;

        PrintResult(legions, outputMatch, soldiersType);
    }
}