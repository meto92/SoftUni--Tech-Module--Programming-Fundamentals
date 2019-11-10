using System;
using System.Linq;
using System.Collections.Generic;

class CODE_PhoenixOscarRomeoNovember
{
    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> squadMatesByCreatures = new Dictionary<string, HashSet<string>>();

        string input;

        while ((input = Console.ReadLine()) != "Blaze it!")
        {
            string[] inputParams = input.Split(new[] { " -> " }, StringSplitOptions.None);

            string creature = inputParams[0];
            string squadMate = inputParams[1];

            if (!squadMatesByCreatures.ContainsKey(creature))
            {
                squadMatesByCreatures[creature] = new HashSet<string>();
            }

            if (creature != squadMate)
            {
                squadMatesByCreatures[creature].Add(squadMate);
            }
        }

        Dictionary<string, int> squadMatesCountByCreatures = new Dictionary<string, int>();

        foreach (KeyValuePair<string, HashSet<string>> pair in squadMatesByCreatures)
        {
            string creature = pair.Key;
            HashSet<string> squadMates = pair.Value;

            if (!squadMatesCountByCreatures.ContainsKey(creature))
            {
                squadMatesCountByCreatures[creature] = 0;
            }

            foreach (string squadMate in squadMates)
            {
                if (!squadMatesByCreatures.ContainsKey(squadMate) ||
                    !squadMatesByCreatures[squadMate].Contains(creature))
                {
                    squadMatesCountByCreatures[creature]++;
                }
            }
        }

        foreach (KeyValuePair<string, int> pair in squadMatesCountByCreatures.OrderByDescending(p => p.Value))
        {
            string creature = pair.Key;
            int squadMatesCount = pair.Value;

            Console.WriteLine($"{creature} : {squadMatesCount}");
        }
    }
}