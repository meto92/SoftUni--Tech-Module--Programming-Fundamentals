using System;
using System.Linq;
using System.Collections.Generic;

class LegendaryFarming
{
    static void ReadAndProcessInput(SortedDictionary<string, int> materials)
    {
        while (true)
        {
            string[] mats = Console.ReadLine().Split(' ');

            for (int i = 0; i < mats.Length; i += 2)
            {
                int quantity = int.Parse(mats[i]);
                string material = mats[i + 1].ToLower();

                if (!materials.ContainsKey(material))
                {
                    materials[material] = 0;
                }

                materials[material] += quantity;

                if (materials[material] >= 250)
                {
                    if (material == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materials[material] -= 250;
                        return;
                    }
                    else if (material == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materials[material] -= 250;
                        return;
                    }
                    else if (material == "motes")
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materials[material] -= 250;
                        return;
                    }
                }
            }
        }
    }

    static void PrintMaterials(SortedDictionary<string, int> materials)
    {
        foreach (KeyValuePair<string, int> pair in materials.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        foreach (KeyValuePair<string, int> pair in materials.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes").OrderByDescending(x => x.Value).OrderBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static void Main(string[] args)
    {
        SortedDictionary<string, int> materials = new SortedDictionary<string, int>();

        materials["shards"] = 0;
        materials["motes"] = 0;
        materials["fragments"] = 0;

        ReadAndProcessInput(materials);
        PrintMaterials(materials);
    }
}