using System;
using System.Linq;

class CondenseArrayToNumber
{
    static long CondenseArray(long[] nums)
    {
        while (nums.Length > 1)
        {
            long[] temp = new long[nums.Length - 1];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                temp[i] = nums[i] + nums[i + 1];
            }

            nums = temp;
        }

        return nums[0];
    }

    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        Console.WriteLine(CondenseArray(nums));
    }
}