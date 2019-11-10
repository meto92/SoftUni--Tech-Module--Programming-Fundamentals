using System;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int bestStartIndex = 0,
            startIndex = 0,
            bestLength = 1,
            length = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                length++;

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStartIndex = startIndex;
                }
            }
            else
            {
                length = 1;
                startIndex = i;
            }
        }

        Console.WriteLine(string.Join(" ", nums.Skip(bestStartIndex).Take(bestLength)));
    }
}