using System;
using System.Linq;

class OddFilter
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().
            Split(' ').
            Select(int.Parse).
            Where(x => x %2 == 0).
            ToArray();

        double average = nums.Average();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > average)
            {
                nums[i]++;
            }
            else
            {
                nums[i]--;
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}