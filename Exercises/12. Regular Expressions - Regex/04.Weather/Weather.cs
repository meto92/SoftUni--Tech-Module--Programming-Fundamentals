using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class TownWeather
{
    private string name;
    private float averageTemperatur;
    private string weather;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float AverageTemperatur
    {
        get { return averageTemperatur; }
        set { averageTemperatur = value; }
    }

    public string Weather
    {
        get { return weather; }
        set { weather = value; }
    }

    public TownWeather(string name)
    {
        Name = name;
    }
}

class Weather
{
    static void Main(string[] args)
    {
        Dictionary<string, TownWeather> dict = new Dictionary<string, TownWeather>();
        Regex pattern = new Regex(@"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|");

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            Match match = pattern.Match(input);

            if (!match.Success)
            {
                continue;
            }

            string town = match.Groups[1].Value;
            float averageTemperature = float.Parse(match.Groups[2].Value);
            string weather = match.Groups[3].Value;

            if (!dict.ContainsKey(town))
            {
                dict[town] = new TownWeather(town);
            }

            dict[town].AverageTemperatur = averageTemperature;
            dict[town].Weather = weather;
        }

        Console.WriteLine(string.Join(Environment.NewLine, dict.OrderBy(t => t.Value.AverageTemperatur).Select(t => $"{t.Key} => {t.Value.AverageTemperatur:f2} => {t.Value.Weather}")));
    }
}