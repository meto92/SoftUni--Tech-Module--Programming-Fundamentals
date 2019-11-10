using System;

class ReverseAnArrayOfIntegers
{
    static void Main(string[] args)
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] nums = new int[arraySize];

        for (int i = arraySize - 1; i >= 0; i--)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}