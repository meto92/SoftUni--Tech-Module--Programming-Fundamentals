using System;
using System.Linq;
using System.Collections.Generic;

class SnowWhite
{
    static void ReadInput(Dictionary<string, Dictionary<string, int>> dwarves)
    {
        string input;

        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] inputParams = input.Split(new[] { " <:> " }, StringSplitOptions.None);

            string dwarfName = inputParams[0];
            string dwarfHatColor = inputParams[1];
            int dwarfPhysics = int.Parse(inputParams[2]);

            if (!dwarves.ContainsKey(dwarfHatColor))
            {
                dwarves[dwarfHatColor] = new Dictionary<string, int>();
            }

            if (!dwarves[dwarfHatColor].ContainsKey(dwarfName))
            {
                dwarves[dwarfHatColor][dwarfName] = dwarfPhysics;
            }
            else
            {
                dwarves[dwarfHatColor][dwarfName] = Math.Max(dwarves[dwarfHatColor][dwarfName], dwarfPhysics);
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> dwarves = new Dictionary<string, Dictionary<string, int>>();

        ReadInput(dwarves);

        List<Tuple<string, string, int>> dwarvesList = new List<Tuple<string, string, int>>();

        foreach (KeyValuePair<string, Dictionary<string, int>> pair in dwarves)
        {
            string dwarfHatColor = pair.Key;

            foreach (KeyValuePair<string, int> p in pair.Value)
            {
                string dwarfName = p.Key;
                int dwarfPhysics = p.Value;

                dwarvesList.Add(new Tuple<string, string, int>(dwarfHatColor, dwarfName, dwarfPhysics));
            }
        }

        foreach (Tuple<string, string, int> dwarf in dwarvesList.OrderByDescending(dwarf => dwarf.Item3).ThenByDescending(dwarf => dwarves[dwarf.Item1].Count))
        {
            string dwarfHatColor = dwarf.Item1;
            string dwarfName = dwarf.Item2;
            int dwarfPhysics = dwarf.Item3;

            Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {dwarfPhysics}");
        }
    }
}