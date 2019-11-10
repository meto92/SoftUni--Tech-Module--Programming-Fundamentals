using System;
using System.Linq;
using System.Collections.Generic;

class AnonymousCache
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, Dictionary<string, long>> dataInfo = new Dictionary<string, Dictionary<string, long>>();

        string input;

        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] items = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            if (items.Length == 1)
            {
                string dataSet = items[0];

                if (!dataInfo.ContainsKey(dataSet))
                {
                    if (cache.ContainsKey(dataSet))
                    {
                        dataInfo[dataSet] = cache[dataSet];
                    }
                    else
                    {
                        dataInfo[dataSet] = new Dictionary<string, long>();
                    }
                }
            }
            else
            {
                string dataKey = items[0];

                string[] otherItems = items[1].Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                int dataSize = int.Parse(otherItems[0]);
                string dataSet = otherItems[1];

                if (dataInfo.ContainsKey(dataSet))
                {
                    if (!dataInfo[dataSet].ContainsKey(dataKey))
                    {
                        dataInfo[dataSet][dataKey] = 0;
                    }

                    dataInfo[dataSet][dataKey] += dataSize;
                }
                else
                {
                    if (!cache.ContainsKey(dataSet))
                    {
                        cache[dataSet] = new Dictionary<string, long>();
                    }

                    if (!cache[dataSet].ContainsKey(dataKey))
                    {
                        cache[dataSet][dataKey] = 0;
                    }

                    cache[dataSet][dataKey] += dataSize;
                }
            }
        }

        if (dataInfo.Any())
        {
            foreach (KeyValuePair<string, Dictionary<string, long>> pair in dataInfo.OrderByDescending(p => dataInfo[p.Key].Values.Sum()).Take(1))
            {
                string dataSet = pair.Key;
                long sumOfAllDataSizes = dataInfo[dataSet].Values.Sum();

                Console.WriteLine($"Data Set: {dataSet}, Total Size: {sumOfAllDataSizes}");

                foreach (string keySet in dataInfo[dataSet].Keys)
                {
                    Console.WriteLine($"$.{keySet}");
                }
            }
        }
    }
}