using System;
using System.Linq;
using System.Collections.Generic;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int startIndex = 0,
            bestStartIndex = 0,
            length = 1,
            bestLength = 1;

        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] == nums[startIndex])
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