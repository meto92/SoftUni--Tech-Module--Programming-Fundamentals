using System;
using System.Linq;

class ArrayModifier
{
    static void Swap(long[] nums, int firstIndex, int secondIndex)
    {
        long temp = nums[firstIndex];
        nums[firstIndex] = nums[secondIndex];
        nums[secondIndex] = temp;
    }

    static void ProcessArray(long[] nums, string action, int firstIndex, int secondIndex)
    {
        if (action == "swap")
        {
            Swap(nums, firstIndex, secondIndex);
        }
        else
        {
            nums[firstIndex] *= nums[secondIndex];
        }
    }

    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        string command;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] items = command.Split();

            string action = items[0];

            if (action == "swap" || action == "multiply")
            {
                int firstIndex = int.Parse(items[1]);
                int secondIndex = int.Parse(items[2]);

                ProcessArray(nums, action, firstIndex, secondIndex);
            }
            else if (action == "decrease")
            {
                nums = nums.Select(x => --x).ToArray();
            }
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}