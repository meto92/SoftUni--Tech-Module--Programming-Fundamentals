using System;
using System.Linq;
using System.Collections.Generic;

class InsertionSortUsingList
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> sortedNumbers = new List<int>();

        foreach (int number in numbers)
        {
            int insertionIndex = sortedNumbers.Count - 1;

            while (insertionIndex >= 0 && sortedNumbers[insertionIndex] > number)
            {
                insertionIndex--;
            }

            sortedNumbers.Insert(insertionIndex + 1, number);
        }

        Console.WriteLine(string.Join(" ", sortedNumbers));
    }
}