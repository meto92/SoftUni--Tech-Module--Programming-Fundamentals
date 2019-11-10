using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RaincastInfo
{
    public string Type { get; set; }
    public string Source { get; set; }
    public string Forecast { get; set; }

    public RaincastInfo(string type)
    {
        Type = type;
    }

    public override string ToString()
    {        
        return $"({Type}) {Forecast} ~ {Source}";
    }
}

class Raincast
{
    static void Main(string[] args)
    {
        Regex typePattern = new Regex("^Type: (Normal|Warning|Danger)$");
        Regex sourcePattern = new Regex("^Source: ([a-zA-Z\\d]+)$");
        Regex forecastPattern = new Regex("^Forecast: ([^!.,?]+)$");

        List<RaincastInfo> raincasts = new List<RaincastInfo>();

        int counter = 0;
        string input;

        while ((input = Console.ReadLine()) != "Davai Emo")
        {
            if (counter % 3 == 0)
            {
                Match match = typePattern.Match(input);

                if (match.Success)
                {
                    raincasts.Add(new RaincastInfo(match.Groups[1].Value));
                    counter++;                
                }
            }
            else if (counter % 3 == 1)
            {
                Match match = sourcePattern.Match(input);

                if (match.Success)
                {
                    raincasts[raincasts.Count - 1].Source = match.Groups[1].Value;
                    counter++;
                }
            }
            else
            {
                Match match = forecastPattern.Match(input);

                if (match.Success)
                {
                    raincasts[raincasts.Count - 1].Forecast = match.Groups[1].Value;
                    counter++;
                }
            }
        }

        foreach (RaincastInfo raincast in raincasts)
        {
            Console.WriteLine(raincast);
        }
    }
}