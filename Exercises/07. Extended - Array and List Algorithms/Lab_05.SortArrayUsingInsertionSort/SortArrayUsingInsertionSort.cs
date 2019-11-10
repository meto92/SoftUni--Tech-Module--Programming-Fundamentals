using System;
using System.Linq;

class SortArrayUsingInsertionSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i < numbers.Length; i++)
        {
            int j = i - 1;
            int temp = numbers[i];

            while (j >= 0 && numbers[j] > temp)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }

            numbers[j + 1] = temp;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}