using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class AMinerTaskam
{
    static void Main(string[] args)
    {
        Dictionary<string, long> resourcesQuantities = new Dictionary<string, long>();

        using (StreamReader reader = new StreamReader("../../Test.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != "stop")
            {
                string resource = line;
                int quantity = int.Parse(reader.ReadLine());

                if (!resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities[resource] = 0;
                }

                resourcesQuantities[resource] += quantity;
            }
        }

        File.WriteAllText("../../Output.txt",
            string.Join(Environment.NewLine, resourcesQuantities.Select(p => $"{p.Key} -> {p.Value}")));
    }
}