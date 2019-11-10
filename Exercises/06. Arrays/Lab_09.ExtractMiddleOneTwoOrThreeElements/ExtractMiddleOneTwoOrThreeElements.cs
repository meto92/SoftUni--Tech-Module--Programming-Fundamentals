using System;
using System.Linq;

class ExtractMiddleOneTwoOrThreeElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (nums.Length == 1)
        {
            Console.WriteLine("{ " + nums[0] + " }");
        }
        else if (nums.Length %2 == 0)
        {
            Console.WriteLine("{ " + $"{nums[nums.Length / 2 - 1]}, {nums[nums.Length / 2]}" + " }");
        }
        else
        {
            Console.WriteLine("{ " + $"{nums[nums.Length / 2 - 1]}, {nums[nums.Length / 2]}, {nums[nums.Length / 2 + 1]}" + " }");
        }
    }
}