using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Trainegram
{
    static void Main(string[] args)
    {
        string pattern = @"^<\[[^\da-zA-Z]*\]\.(\.\[[a-zA-Z\d]*\]\.)*$";
        List<string> trains = new List<string>();
        string input;

        while ((input = Console.ReadLine()) != "Traincode!")
        {
            if (Regex.IsMatch(input, pattern))
            {
                trains.Add(input);
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, trains));
    }
}