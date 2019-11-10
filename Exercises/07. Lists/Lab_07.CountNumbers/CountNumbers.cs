using System;
using System.Linq;
using System.Collections.Generic;

class CountNumbers
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        SortedDictionary<int, int> numbersCounts = new SortedDictionary<int, int>();

        for (int i = 0; i < nums.Count; i++)
        {
            int num = nums[i];

            if (!numbersCounts.ContainsKey(num))
            {
                numbersCounts[num] = 0;
            }

            numbersCounts[num]++;
        }

        foreach (KeyValuePair<int, int> pair in numbersCounts)
        {
            int number = pair.Key;
            int count = pair.Value;

            Console.WriteLine($"{number} -> {count}");
        }
    }
}