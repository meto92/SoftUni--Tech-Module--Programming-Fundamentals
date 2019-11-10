using System;
using System.Linq;
using System.Collections.Generic;

class IncreasingCrisis
{
    static int GetInsertIndex(List<int> sequence, int element)
    {
        if (sequence.Count == 0)
        {
            return 0;
        }

        int insertIndex = 0;

        while (insertIndex < sequence.Count && sequence[insertIndex] <= element )
        {
            insertIndex++;
        }

        return insertIndex;
    }

    static void Main(string[] args)
    {
        int linesCount = int.Parse(Console.ReadLine());

        List<int> sequence = new List<int>();

        for (int i = 0; i < linesCount; i++)
        {
            int[] nums = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();

            int insertIndex = GetInsertIndex(sequence, nums[0]);
            int currentIndex = insertIndex;

            foreach (int num in nums)
            {
                sequence.Insert(currentIndex, num);

                if (sequence.Count > 1 && num < sequence[currentIndex - 1])
                {
                    sequence = sequence.Take(insertIndex).ToList();
                    break;
                }

                currentIndex++;
            }
            Console.WriteLine(string.Join(" ", sequence));

        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}
// 80/100