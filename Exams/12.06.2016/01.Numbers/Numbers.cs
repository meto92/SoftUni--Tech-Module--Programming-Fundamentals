using System;
using System.Linq;
using System.Collections.Generic;

class Numbers
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        IEnumerable<int> biggestFiveNumbersGreaterThanAverage = nums.OrderByDescending(x => x).Where(x => x > nums.Average()).Take(5);

        if (!biggestFiveNumbersGreaterThanAverage.Any())
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", biggestFiveNumbersGreaterThanAverage));
        }
    }
}