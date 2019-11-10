using System;
using System.Linq;
using System.Collections.Generic;

class LogsAggregator
{
    static void ReadAndProcessInput(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        int logLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < logLines; i++)
        {
            string[] log = Console.ReadLine().Split(' ');

            string IP = log[0];
            string userName = log[1];
            int duration = int.Parse(log[2]);

            if (!logs.ContainsKey(userName))
            {
                logs[userName] = new SortedDictionary<string, int>();
            }

            if (!logs[userName].ContainsKey(IP))
            {
                logs[userName][IP] = 0;
            }

            logs[userName][IP] += duration;
        }
    }

    static void PrintResult(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        foreach (KeyValuePair<string, SortedDictionary<string, int>> pair in logs)
        {
            string userName = pair.Key;
            int totalDuration = logs[userName].Values.Sum();

            Console.WriteLine($"{userName}: {totalDuration} [{string.Join(", ", logs[userName].Keys)}]");
        }
    }

    static void Main(string[] args)
    {
        SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

        ReadAndProcessInput(logs);
        PrintResult(logs);
    }
}