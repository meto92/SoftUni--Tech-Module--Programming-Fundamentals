using System;
using System.Linq;
using System.Collections.Generic;

class CountRealNumbers
{
    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            double num = nums[i];

            if (!numbersCount.ContainsKey(num))
            {
                numbersCount[num] = 0;
            }

            numbersCount[num]++;
        }

        foreach (KeyValuePair<double, int> pair in numbersCount)
        {
            double num = pair.Key;
            int count = pair.Value;

            Console.WriteLine($"{num} -> {count}");
        }
    }
}