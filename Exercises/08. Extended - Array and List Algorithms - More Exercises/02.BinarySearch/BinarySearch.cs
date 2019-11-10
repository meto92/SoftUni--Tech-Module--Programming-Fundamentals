using System;
using System.Linq;

class BinarySearch
{
    static void PrintLinearSearchIterations(int[] numbers, int element)
    {
        int index = Array.IndexOf(numbers, element);

        int iterations = index != -1
            ? index + 1
            : numbers.Length;

        Console.WriteLine($"Linear search made {iterations} iterations");
    }

    static void PrintBinarySearchIterations(int[] numbers, int element)
    {
        Array.Sort(numbers);

        int start = 0,
            end = numbers.Length - 1,
            middle = end / 2,
            iterations = 1;

        while (numbers[middle] != element && start != end)
        {
            if (element < numbers[middle])
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }

            middle = (end - start) / 2 + start;
            iterations++;
        }

        Console.WriteLine($"Binary search made {iterations} iterations");
    }

    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int element = int.Parse(Console.ReadLine());

        if (numbers.Contains(element))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        PrintLinearSearchIterations(numbers, element);
        PrintBinarySearchIterations(numbers, element);
    }
}