using System;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            long leftSum = nums.Take(i).Sum(),
                rightSum = nums.Skip(i + 1).Take(nums.Length).Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine("no");
    }
}