using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Event
{
    public int ID { get; set; }
    public string EventName { get; set; }
    public SortedSet<string> Participants { get; set; }

    public Event(int id, string eventName)
    {
        ID = id;
        EventName = eventName;
        Participants = new SortedSet<string>();
    }
}

class RoliTheCoder
{
    static void Main(string[] args)
    {
        Dictionary<int, Event> events = new Dictionary<int, Event>();

        Regex pattern = new Regex(@"(\d+)\s+#([a-zA-Z\d]+)((\s+@[a-zA-Z\d'-]+)*)");

        string input;

        while ((input = Console.ReadLine()) != "Time for Code")
        {
            Match match = pattern.Match(input);

            if (!match.Success)
            {
                continue;
            }

            int id = int.Parse(match.Groups[1].Value);
            string eventName = match.Groups[2].Value;
            List<string> participants = match.Groups[3].Value.
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(p => p.Substring(1)).
                ToList();

            if (!events.ContainsKey(id))
            {
                events[id] = new Event(id, eventName);
            }

            if (events[id].EventName == eventName)
            {
                foreach (string participant in participants)
                {
                    events[id].Participants.Add(participant);
                }
            }
        }

        foreach (KeyValuePair<int, Event> pair in events.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.EventName))
        {
            string eventName = pair.Value.EventName;
            int participantsCount = pair.Value.Participants.Count;

            Console.WriteLine($"{eventName} - {participantsCount}");

            foreach (string participant in pair.Value.Participants)
            {
                Console.WriteLine($"@{participant}");
            }
        }
    }
}