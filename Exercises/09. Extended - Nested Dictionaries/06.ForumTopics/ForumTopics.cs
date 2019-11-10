using System;
using System.Linq;
using System.Collections.Generic;

class ForumTopics
{
    static bool ContainsAllRequestedTags(List<string> tags, string[] requestedTags)
    {
        foreach (string tag in requestedTags)
        {
            if (!tags.Contains(tag))
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Dictionary<string, List<string>> tagsByTopic = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "filter")
        {
            string[] items = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string topic = items[0];
            string[] tags = items[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            if (!tagsByTopic.ContainsKey(topic))
            {
                tagsByTopic[topic] = new List<string>();
            }

            foreach (string tag in tags.Where(t => !tagsByTopic[topic].Contains(t)))
            {
                tagsByTopic[topic].Add(tag);
            }
        }

        string[] requestedTags = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        foreach (KeyValuePair<string, List<string>> pair in tagsByTopic)
        {
            string topic = pair.Key;
            List<string> tags = pair.Value;

            if (ContainsAllRequestedTags(tags, requestedTags))
            {
                Console.WriteLine($"{topic} | {string.Join(", ", tags.Select(t => $"#{t}"))}");
            }
        }
    }
}