using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class FootballTeam
{
    public string TeamName { get; set; }
    public long Goals { get; set; }
    public int Points { get; set; }

    public FootballTeam(string teamName)
    {
        TeamName = teamName;
        Goals = 0;
        Points = 0;
    }
}

class FootballLeague
{
    static string[] GetTeams(string input, string key)
    {
        int[] keyIndices = new int[4];

        keyIndices[0] = input.IndexOf(key);

        for (int i = 1; i < 4; i++)
        {
            keyIndices[i] = input.IndexOf(key, keyIndices[i - 1] + key.Length);
        }

        string[] teams = new string[2];

        for (int i = 0; i < 2; i++)
        {
            teams[i] = new string(input.Substring(keyIndices[2 * i] + key.Length, keyIndices[2 * i + 1] - key.Length - keyIndices[2 * i]).ToUpper().Reverse().ToArray());
        }
        
        return teams;
    }

    static void Main(string[] args)
    {
        string key = Console.ReadLine();

        Dictionary<string, FootballTeam> teamsInfo = new Dictionary<string, FootballTeam>();

        Regex scorePattern = new Regex(@"(\d+):(\d+)$");
        string input;

        while ((input = Console.ReadLine()) != "final")
        {
            string[] teams = GetTeams(input, key);
            string firstTeam = teams[0];
            string secondTeam = teams[1];

            if (!teamsInfo.ContainsKey(firstTeam))
            {
                teamsInfo[firstTeam] = new FootballTeam(firstTeam);
            }

            if (!teamsInfo.ContainsKey(secondTeam))
            {
                teamsInfo[secondTeam] = new FootballTeam(secondTeam);
            }

            Match score = scorePattern.Match(input);

            int firstTeamGoals = int.Parse(score.Groups[1].Value);
            int secondTeamGoals = int.Parse(score.Groups[2].Value);

            teamsInfo[firstTeam].Goals += firstTeamGoals;
            teamsInfo[secondTeam].Goals += secondTeamGoals;

            if (firstTeamGoals > secondTeamGoals)
            {
                teamsInfo[firstTeam].Points += 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                teamsInfo[secondTeam].Points += 3;
            }
            else
            {
                teamsInfo[firstTeam].Points += 1;
                teamsInfo[secondTeam].Points += 1;
            }
        }

        int place = 0;

        Console.WriteLine("League standings:");

        foreach (KeyValuePair<string, FootballTeam> pair in teamsInfo.OrderByDescending(team => team.Value.Points).ThenBy(team => team.Value.TeamName))
        {
            Console.WriteLine($"{++place}. {pair.Key} {pair.Value.Points}");
        }

        Console.WriteLine("Top 3 scored goals:");

        foreach (KeyValuePair<string, FootballTeam> pair in teamsInfo.OrderByDescending(team => team.Value.Goals).ThenBy(team => team.Value.TeamName).Take(3))
        {
            Console.WriteLine($"- {pair.Key} -> {pair.Value.Goals}");
        }
    }
}