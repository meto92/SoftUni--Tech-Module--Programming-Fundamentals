using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class AnonymousThreat
{
    static void Merge(ref List<string> strings, int startIndex, int endIndex)
    {
        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (endIndex >= strings.Count)
        {
            endIndex = strings.Count - 1;
        }

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            strings[startIndex] += strings[i];
        }

        int itemsToDelete = endIndex - startIndex;

        for (int i = startIndex + 1; itemsToDelete > 0; itemsToDelete--)
        {
            strings.RemoveAt(i);
        }
    }

    static void Divide(List<string> strings, int index, int partitions)
    {
        if (partitions == 0)
        {
            return;
        }

        string[] parts = new string[partitions];
        int partitionLength = strings[index].Length / partitions;

        for (int i = 0; i < partitions - 1; i++)
        {
            parts[i] = new string(strings[index].Skip(i * partitionLength).Take(partitionLength).ToArray());
        }

        if (strings[index].Length % partitions == 0)
        {
            parts[partitions - 1] = new string(strings[index].Skip((partitions - 1) * partitionLength).Take(partitionLength).ToArray());
        }
        else
        {
            parts[partitions - 1] = new string(strings[index].Skip((partitions - 1) * partitionLength).Take(strings[index].Length).ToArray());
        }

        strings.RemoveAt(index);
        strings.InsertRange(index, parts);
    }

    static void Main(string[] args)
    {
        List<string> strings = Regex.Split(Console.ReadLine(), "\\s+").ToList();

        string input;

        while ((input = Console.ReadLine()) != "3:1")
        {
            string[] items = input.Split();

            string action = items[0];

            if (action == "merge")
            {
                int startIndex = int.Parse(items[1]);
                int endIndex = int.Parse(items[2]);

                Merge(ref strings, startIndex, endIndex);
            }
            else
            {
                int index = int.Parse(items[1]);
                int partitions = int.Parse(items[2]);

                Divide(strings, index, partitions);
            }
        }

        Console.WriteLine(string.Join(" ", strings));
    }
}