using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNegativesAndReverse
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        nums = nums.Where(x => x >= 0).ToList();

        if (nums.Count > 0)
        {
            nums.Reverse();

            Console.WriteLine(string.Join(" ", nums));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}