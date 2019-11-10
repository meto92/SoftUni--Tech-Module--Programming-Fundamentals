using System;
using System.Linq;

class ArrayContainsElement
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int element = int.Parse(Console.ReadLine());

        bool isElementContained = numbers.Contains(element);

        if (isElementContained)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}