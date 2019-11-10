using System;
using System.Linq;
using System.Collections.Generic;

class SearchForA_Number
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int numberOfElementsToTake = nums[0],
            numberOfElementsToDelete = nums[1],
            searchNumber = nums[2];

        if (numbers.Take(numberOfElementsToTake).Skip(numberOfElementsToDelete).Contains(searchNumber))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}