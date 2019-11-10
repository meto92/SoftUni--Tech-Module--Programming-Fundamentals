using System;
using System.Linq;

class SortArrayUsingBubbleSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int end = numbers.Length - 1; end > 0; end--)
        {
            bool swapped = false;

            for (int i = 0; i < end; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp = numbers[i];

                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}