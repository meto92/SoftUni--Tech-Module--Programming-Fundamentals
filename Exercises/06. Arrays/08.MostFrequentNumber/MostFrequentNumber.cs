using System;
using System.Linq;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

        Dictionary<ushort, int> numsOccurrences = new Dictionary<ushort, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!numsOccurrences.ContainsKey(nums[i]))
            {
                numsOccurrences[nums[i]] = 0;
            }

            numsOccurrences[nums[i]]++;
        }

        Console.WriteLine(numsOccurrences.OrderByDescending(pair => pair.Value).First().Key);
    }
}