using System;
using System.Linq;

class ArrayStatistics
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        Console.WriteLine($"Min = {nums.Min()}");
        Console.WriteLine($"Max = {nums.Max()}");
        Console.WriteLine($"Sum = {nums.Sum()}");
        Console.WriteLine($"Average = {nums.Average()}");
    }
}