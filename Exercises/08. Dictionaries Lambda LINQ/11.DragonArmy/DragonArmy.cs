using System;
using System.Collections.Generic;

class DragonArmy
{
    static void AddDragon(Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo, string type, string name, int damage, int health, int armor)
    {
        if (!dragonsInfo.ContainsKey(type))
        {
            dragonsInfo[type] = new SortedDictionary<string, int[]>();
        }

        dragonsInfo[type][name] = new int[3];

        dragonsInfo[type][name][0] = damage;
        dragonsInfo[type][name][1] = health;
        dragonsInfo[type][name][2] = armor;
    }

    static double GetTypeAverageDamage(Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo, string type)
    {
        int totalDamage = 0;

        foreach (KeyValuePair<string, int[]> pair in dragonsInfo[type])
        {
            totalDamage += dragonsInfo[type][pair.Key][0];
        }

        return (double)totalDamage / dragonsInfo[type].Count;
    }

    static double GetTypeAverageHealth(Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo, string type)
    {
        int totalHealth = 0;

        foreach (KeyValuePair<string, int[]> pair in dragonsInfo[type])
        {
            totalHealth += dragonsInfo[type][pair.Key][1];
        }

        return (double)totalHealth / dragonsInfo[type].Count;
    }

    static double GetTypeAverageArmor(Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo, string type)
    {
        int totalArmor = 0;

        foreach (KeyValuePair<string, int[]> pair in dragonsInfo[type])
        {
            totalArmor += dragonsInfo[type][pair.Key][2];
        }

        return (double)totalArmor / dragonsInfo[type].Count;
    }

    static void PrintDragonsStatistics(Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo)
    {
        foreach (KeyValuePair<string, SortedDictionary<string, int[]>> pair in dragonsInfo)
        {
            string type = pair.Key;
            double typeAverageDamage = GetTypeAverageDamage(dragonsInfo, type);
            double typeAverageHealth = GetTypeAverageHealth(dragonsInfo, type);
            double typeAverageArmor = GetTypeAverageArmor(dragonsInfo, type);

            Console.WriteLine($"{type}::({typeAverageDamage:f2}/{typeAverageHealth:f2}/{typeAverageArmor:f2})");

            foreach (KeyValuePair<string, int[]> p in dragonsInfo[type])
            {
                string name = p.Key;
                int damage = p.Value[0];
                int health = p.Value[1];
                int armor = p.Value[2];

                Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, SortedDictionary<string, int[]>> dragonsInfo = new Dictionary<string, SortedDictionary<string, int[]>>();

        int numberOfDragons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfDragons; i++)
        {
            string[] items = Console.ReadLine().Split(' ');

            string type = items[0];
            string name = items[1];

            int damage = 45,
                health = 250,
                armor = 10;

            if (items[2] != "null")
            {
                damage = int.Parse(items[2]);
            }

            if (items[3] != "null")
            {
                health = int.Parse(items[3]);
            }

            if (items[4] != "null")
            {
                armor = int.Parse(items[4]);
            }

            AddDragon(dragonsInfo, type, name, damage, health, armor);
        }

        PrintDragonsStatistics(dragonsInfo);
    }
}