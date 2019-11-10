using System;
using System.Linq;

class ReverseArrayInplace
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];

            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = temp;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}