using System;
using System.Linq;
using System.Collections.Generic;

class LongestIncreasingSubsequence
{
    static void InitArrays(int[] len, int[] prev)
    {
        for (int i = 0; i < prev.Length; i++)
        {
            prev[i] = -1;
            len[i] = 1;
        }
    }

    static void SetArrays(List<int> numbers, int[] len, int[] prev)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int left = numbers[i];

            for (int j = i + 1; j < numbers.Count; j++)
            {
                int right = numbers[j];

                if (len[i] + 1 > len[j] && right > left)
                {
                    len[j] = len[i] + 1;
                    prev[j] = i;
                }
            }
        }
    }

    static void PrintResult(List<int> numbers, int[] len, int[] prev)
    {
        int lenIndex = Array.IndexOf(len, len.Max());
        int index = prev[lenIndex];

        Stack<int> result = new Stack<int>();
        result.Push(numbers[lenIndex]);

        while (index != -1)
        {
            result.Push(numbers[index]);
            index = prev[index];
        }

        Console.WriteLine(string.Join(" ", result));
    }

    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int[] len = new int[numbers.Count];
        int[] prev = new int[numbers.Count];

        InitArrays(len, prev);
        SetArrays(numbers, len, prev);
        PrintResult(numbers, len, prev);
    }
}