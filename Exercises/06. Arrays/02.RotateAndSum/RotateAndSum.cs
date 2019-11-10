using System;
using System.Linq;

class RotateAndSum
{
    static void RotateRight(long[] nums)
    {
        long lastElement = nums[nums.Length - 1];

        for (int i = nums.Length - 1; i > 0; i--)
        {
            nums[i] = nums[i - 1];
        }

        nums[0] = lastElement;
    }

    static void SumArrays(long[] nums, long[] sum)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            sum[i] += nums[i];
        }
    }

    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());

        long[] sum = new long[nums.Length];

        for (int k = 0; k < rotations; k++)
        {
            RotateRight(nums);
            SumArrays(nums, sum);
        }

        // using hints:
        //for (int r = 1; r <= rotations; r++)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum[(i + r) % nums.Length] += nums[i];
        //    }
        //}

        Console.WriteLine(string.Join(" ", sum));
    }
}