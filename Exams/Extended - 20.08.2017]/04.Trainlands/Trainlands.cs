using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Wagon
{
    public string WagonName { get; set; }
    public int WagonPower { get; set; }

    public Wagon(string wagonName, int wagonPower)
    {
        this.WagonName = wagonName;
        this.WagonPower = wagonPower;
    }
}

class Trainlands
{
    static void AddWagon(Dictionary<string, List<Wagon>> trains, string[] tokens)
    {
        string trainName = tokens[0];
        string wagonName = tokens[1];
        int wagonPower = int.Parse(tokens[2]);

        if (!trains.ContainsKey(trainName))
        {
            trains[trainName] = new List<Wagon>();
        }

        trains[trainName].Add(new Wagon(wagonName, wagonPower));
    }

    static void AddAllWagons(Dictionary<string, List<Wagon>> trains, string[] tokens)
    {
        string trainName = tokens[0];
        string otherTrainName = tokens[1];

        if (!trains.ContainsKey(trainName))
        {
            trains[trainName] = new List<Wagon>();
        }

        trains[trainName].AddRange(trains[otherTrainName]);
        trains.Remove(otherTrainName);
    }

    static void CopyWagons(Dictionary<string, List<Wagon>> trains, string[] tokens)
    {
        string trainName = tokens[0];
        string otherTrainName = tokens[1];

        trains[trainName] = new List<Wagon>();
        trains[trainName].AddRange(trains[otherTrainName]);
    }

    static void Main(string[] args)
    {
        Dictionary<string, List<Wagon>> trains = new Dictionary<string, List<Wagon>>();

        string input;

        while ((input = Console.ReadLine()) != "It's Training Men!")
        {
            string[] tokens = Regex.Split(input, "[ :>=-]+");

            if (input.Contains("->"))
            {
                if (tokens.Length == 3)
                {
                    AddWagon(trains, tokens);
                }
                else
                {
                    AddAllWagons(trains, tokens);
                }
            }
            else
            {
                CopyWagons(trains, tokens);
            }
        }

        foreach (KeyValuePair<string, List<Wagon>> pair in trains.OrderByDescending(p => p.Value.Sum(wagon => wagon.WagonPower)).ThenBy(p => p.Value.Count))
        {
            string trainName = pair.Key;
            IEnumerable<Wagon> wagons = pair.Value.OrderByDescending(wagon => wagon.WagonPower);

            Console.WriteLine($"Train: {trainName}");
            Console.WriteLine(string.Join(Environment.NewLine, wagons.Select(wagon => $"###{wagon.WagonName} - {wagon.WagonPower}")));
        }
    }    
}