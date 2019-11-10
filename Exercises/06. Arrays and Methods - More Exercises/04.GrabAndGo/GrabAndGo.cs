using System;
using System.Linq;

class GrabAndGo
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long number = long.Parse(Console.ReadLine());

        if (nums.Contains(number))
        {
            long sum = nums.Take(Array.LastIndexOf(nums, number)).Sum();

            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}