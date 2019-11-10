using System;
using System.Linq;
using System.Collections.Generic;

class SortNumbers
{
    static void Main(string[] args)
    {
        List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        nums.Sort();

        Console.WriteLine(string.Join(" <= ", nums));
    }
}