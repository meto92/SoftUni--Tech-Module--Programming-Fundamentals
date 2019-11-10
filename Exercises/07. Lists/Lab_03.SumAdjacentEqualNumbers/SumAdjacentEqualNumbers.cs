using System;
using System.Linq;
using System.Collections.Generic;

class SumAdjacentEqualNumbers
{
    static void Main(string[] args)
    {
        List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                nums[i - 1] *= 2;
                nums.RemoveAt(i);
            }
            else if (i >= 0 &&i < nums.Count - 1 && nums[i] == nums[i + 1])
            {
                nums[i] *= 2;
                nums.RemoveAt(i + 1);
                i-=2;
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}