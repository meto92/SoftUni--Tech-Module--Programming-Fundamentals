using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class HornetComm
{
    static string GetFrequency(string frequency)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < frequency.Length; i++)
        {
            char c = frequency[i];

            if (char.IsLetter(c) && char.IsLower(c))
            {
                sb.Append(char.ToUpper(c));
            }
            else if (char.IsLetter(c) && char.IsUpper(c))
            {
                sb.Append(char.ToLower(c));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    static void PrintResult(string type, List<string> collection)
    {
        Console.WriteLine($"{type}:");

        if (collection.Any())
        {
            Console.WriteLine(string.Join(Environment.NewLine, collection));
        }
        else
        {
            Console.WriteLine("None");
        }
    }

    static void Main(string[] args)
    {
        Regex privateMessagePattern = new Regex(@"^(\d+) <-> ([a-zA-Z\d]+)$");
        Regex broadcastPattern = new Regex(@"^(\D+) <-> ([a-zA-Z\d]+)$");

        List<string> messages = new List<string>();
        List<string> broadcasts = new List<string>();

        string input;

        while ((input = Console.ReadLine()) != "Hornet is Green")
        {
            Match privateMessage = privateMessagePattern.Match(input);
            Match broadcast = broadcastPattern.Match(input);

            if (privateMessage.Success)
            {
                string recipientCode = new string(privateMessage.Groups[1].Value.Reverse().ToArray());
                string message = privateMessage.Groups[2].Value;

                messages.Add($"{recipientCode} -> {message}");
            }
            else if (broadcast.Success)
            {
                string message = broadcast.Groups[1].Value;
                string frequency = GetFrequency(broadcast.Groups[2].Value);

                broadcasts.Add($"{frequency} -> {message}");
            }
        }

        PrintResult("Broadcasts", broadcasts);
        PrintResult("Messages", messages);
    }
}