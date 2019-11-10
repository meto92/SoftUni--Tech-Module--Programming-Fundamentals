using System;
using System.Linq;

class Sum_Min_Max_Average
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());

        int[] nums = new int[numbersCount];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum = {nums.Sum()}");
        Console.WriteLine($"Min = {nums.Min()}");
        Console.WriteLine($"Max = {nums.Max()}");
        Console.WriteLine($"Average = {nums.Average()}");
    }
}