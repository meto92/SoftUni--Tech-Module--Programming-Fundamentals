using System;
using System.Linq;
using System.Collections.Generic;

class AppendLists
{
    static void Main(string[] args)
    {
        string allLists = Console.ReadLine();

        string[] separatedLists = allLists.Split('|');

        List<List<int>> lists = new List<List<int>>();

        for (int i = separatedLists.Length - 1; i >=0 ; i--)
        {
            lists.Add(separatedLists[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
        }

        List<int> result = new List<int>();

        for (int i = 0; i < lists.Count; i++)
        {
            result.AddRange(lists[i]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}