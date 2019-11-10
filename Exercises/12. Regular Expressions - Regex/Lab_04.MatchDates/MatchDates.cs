﻿using System;
using System.Text.RegularExpressions;

class MatchDates
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

        string datesString = Console.ReadLine();

        MatchCollection matchedDates = pattern.Matches(datesString);

        foreach (Match date in matchedDates)
        {
            string day = date.Groups["day"].Value;
            string month = date.Groups["month"].Value;
            string year = date.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}