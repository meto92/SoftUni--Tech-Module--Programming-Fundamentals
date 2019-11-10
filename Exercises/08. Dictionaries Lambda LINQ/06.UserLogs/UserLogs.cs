using System;
using System.Text;
using System.Collections.Generic;

class UserLogs
{
    static void AddMessage(SortedDictionary<string, Dictionary<string, List<string>>> messages, string IP, string message, string userName)
    {
        if (!messages.ContainsKey(userName))
        {
            messages[userName] = new Dictionary<string, List<string>>();
        }

        if (!messages[userName].ContainsKey(IP))
        {
            messages[userName][IP] = new List<string>();
        }

        messages[userName][IP].Add(message);
    }

    static void PrintResult(SortedDictionary<string, Dictionary<string, List<string>>> messages)
    {
        foreach (KeyValuePair<string, Dictionary<string, List<string>>> pair in messages)
        {
            string userName = pair.Key;
            Console.WriteLine($"{userName}:");

            StringBuilder IPs = new StringBuilder();

            foreach (KeyValuePair<string, List<string>> message in messages[userName])
            {
                string IP = message.Key;
                int messagesCount = messages[userName][IP].Count;

                IPs.Append($"{IP} => {messagesCount}, ");
            }

            IPs.Length -= 2;

            Console.WriteLine($"{IPs}.");
        }
    }

    static void Main(string[] args)
    {
        SortedDictionary<string, Dictionary<string, List<string>>> messages = new SortedDictionary<string, Dictionary<string, List<string>>>();

        string line;

        while ((line = Console.ReadLine()) != "end")
        {
            string[] items = line.Split();

            string IP = items[0].Substring(3, items[0].Length - 3);
            string message = items[1].Substring(9, items[1].Length - 10);
            string userName = items[2].Substring(5, items[2].Length - 5);

            AddMessage(messages, IP, message, userName);
        }

        PrintResult(messages);
    }
}