using System;
using System.Linq;
using System.Collections.Generic;

class SoftUniKaraoke
{
    static void Main(string[] args)
    {
        List<string> participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        SortedDictionary<string, SortedSet<string>> awards = new SortedDictionary<string, SortedSet<string>>();

        string input;

        while ((input = Console.ReadLine()) != "dawn")
        {
            string[] performanceArgs = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string participant = performanceArgs[0];
            string song = performanceArgs[1].Trim();
            string award = performanceArgs[2].Trim();

            if (!participants.Contains(participant) || !songs.Contains(song))
            {
                continue;
            }

            if (!awards.ContainsKey(participant))
            {
                awards[participant] = new SortedSet<string>();
            }

            awards[participant].Add(award);
        }

        foreach (KeyValuePair<string, SortedSet<string>> pair in 
            awards.OrderByDescending(p => p.Value.Count))
        {
            string participant = pair.Key;
            int uniqueAwards = pair.Value.Count;

            Console.WriteLine($"{participant}: {uniqueAwards} awards");

            foreach (string award in pair.Value)
            {
                Console.WriteLine($"--{award}");
            }
        }

        if (!awards.Any())
        {
            Console.WriteLine("No awards");
        }
    }
}