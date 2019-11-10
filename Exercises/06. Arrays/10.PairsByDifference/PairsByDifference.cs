using System;
using System.Linq;

class PairsByDifference
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());

        int pairsByDifferenceCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] - nums[j] == difference || nums[j] - nums[i] == difference)
                {
                    pairsByDifferenceCount++;
                }
            }
        }

        Console.WriteLine(pairsByDifferenceCount);
    }
}