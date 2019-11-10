using System;
using System.Collections.Generic;

class Wardrobe
{
    static void AddItems(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] clothes)
    {
        if (!wardrobe.ContainsKey(color))
        {
            wardrobe[color] = new Dictionary<string, int>();
        }

        foreach (string item in clothes)
        {
            if (!wardrobe[color].ContainsKey(item))
            {
                wardrobe[color][item] = 0;
            }

            wardrobe[color][item]++;
        }
    }

    static void Main(string[] args)
    {
        int iinesCount = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < iinesCount; i++)
        {
            string[] items = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            string color = items[0];
            string[] clothes = items[1].Split(',');

            AddItems(wardrobe, color, clothes);
        }

        string[] request = Console.ReadLine().Split(' ');

        string requestedColor = request[0];
        string requestedItem = request[1];

        foreach (KeyValuePair<string, Dictionary<string, int>> pair in wardrobe)
        {
            string color = pair.Key;

            Console.WriteLine($"{color} clothes:");

            foreach (KeyValuePair<string, int> p in wardrobe[color])
            {
                string item = p.Key;
                int count = p.Value;

                Console.WriteLine("* {0} - {1}{2}", item, count, color == requestedColor && item == requestedItem ? " (found!)" : string.Empty);
            }
        }
    }
}