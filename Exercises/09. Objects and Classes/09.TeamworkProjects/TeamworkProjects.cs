using System;
using System.Linq;
using System.Collections.Generic;

class Team
{
    private string creator;
    private string teamName;
    private List<string> members;

    public string Creator
    {
        get { return creator; }
        set { creator = value; }
    }

    public string TeamName
    {
        get { return teamName; }
        set { teamName = value; }
    }

    public List<string> Members
    {
        get { return members; }
        set { members = value; }
    }


    public Team(string creator, string teamName)
    {
        Creator = creator;
        TeamName = teamName;
        members = new List<string>();
    }
}

class TeamworkProjects
{
    static bool IsUserAlreadyInTeam(SortedDictionary<string, Team> teams, string user)
    {
        foreach (KeyValuePair<string, Team> pair in teams)
        {
            if (pair.Value.Creator == user)
            {
                return true;
            }

            for (int i = 0; i < pair.Value.Members.Count; i++)
            {
                if (pair.Value.Members[i] == user)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static bool HasUserAlreadyCreatedTeam(SortedDictionary<string, Team> teams, string user)
    {
        foreach (KeyValuePair<string, Team> pair in teams)
        {
            if (pair.Value.Creator == user)
            {
                return true;
            }
        }

        return false;
    }

    static void CreateNewTeams(SortedDictionary<string, Team> teams, int numberOfTeams)
    {
        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] teamParams = Console.ReadLine().Split('-');

            string user = teamParams[0];
            string teamName = teamParams[1];

            bool teamAlreadyExists = teams.ContainsKey(teamName);
            bool hasUserAlreadyCreatedTeam = HasUserAlreadyCreatedTeam(teams, user);

            if (teamAlreadyExists)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (hasUserAlreadyCreatedTeam)
            {
                Console.WriteLine($"{user} cannot create another team!");
                continue;
            }
            
            Team team = new Team(user, teamName);

            teams[teamName] = team;

            Console.WriteLine($"Team {teamName} has been created by {user}!");
        }
    }

    static void AddMembers(SortedDictionary<string, Team> teams)
    {
        string input;

        while ((input = Console.ReadLine()) != "end of assignment")
        {
            string[] items = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

            string user = items[0];
            string teamName = items[1];

            bool teamExists = teams.ContainsKey(teamName);
            bool isUserAlreadyInTeam = IsUserAlreadyInTeam(teams, user);

            if (!teamExists)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (isUserAlreadyInTeam)
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

           teams[teamName].Members.Add(user);
        }
    }

    static void PrintResult(SortedDictionary<string, Team> teams)
    {
        List<string> teamsToDisband = new List<string>();

        foreach (KeyValuePair<string, Team> pair in teams.OrderByDescending(p => p.Value.Members.Count))
        {
            if (pair.Value.Members.Count == 0)
            {
                teamsToDisband.Add(pair.Key);
                continue;
            }

            string teamName = pair.Key;
            string creator = pair.Value.Creator;
            List<string> members = pair.Value.Members.OrderBy(name => name).ToList();

            Console.WriteLine(teamName);
            Console.WriteLine($"- {creator}");

            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"-- {members[i]}");
            }
        }

        Console.WriteLine($"Teams to disband:\n{string.Join("\n", teamsToDisband)}");
    }

    static void Main(string[] args)
    {
        int numberOfTeams = int.Parse(Console.ReadLine());

        SortedDictionary<string, Team> teams = new SortedDictionary<string, Team>();

        CreateNewTeams(teams, numberOfTeams);
        AddMembers(teams);
        PrintResult(teams);
    }
}