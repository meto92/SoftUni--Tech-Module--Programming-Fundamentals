using System;
using System.Linq;

class PlayCatch
{
    static void Replace(int[] nums, string[] items, ref int exceptionsCount)
    {
        int index = 0;
        int element = 0;

        try
        {
            index = int.Parse(items[1]);
            element = int.Parse(items[2]);
        }
        catch (Exception)
        {
            Console.WriteLine("The variable is not in the correct format!");
            exceptionsCount++;
            return;
        }

        if (index < 0 || index >= nums.Length)
        {
            Console.WriteLine("The index does not exist!");
            exceptionsCount++;
            return;
        }

        nums[index] = element;
    }

    static void Print(int[] nums, string[] items, ref int exceptionsCount)
    {
        int startIndex = 0;
        int endIndex = 0;

        try
        {
            startIndex = int.Parse(items[1]);
            endIndex = int.Parse(items[2]);
        }
        catch (Exception)
        {
            Console.WriteLine("The variable is not in the correct format!");
            exceptionsCount++;
            return;
        }

        if (startIndex < 0 || endIndex >= nums.Length)
        {
            Console.WriteLine("The index does not exist!");
            exceptionsCount++;
            return;
        }

        Console.WriteLine(string.Join(", ", nums.Skip(startIndex).Take(endIndex - startIndex + 1)));
    }

    static void PrintAtIndex(int[] nums, string[] items, ref int exceptionsCount)
    {
        int index = 0;

        try
        {
            index = int.Parse(items[1]);

        }
        catch (Exception)
        {

            Console.WriteLine("The variable is not in the correct format!");
            exceptionsCount++;
            return;
        }

        if (index < 0 || index >= nums.Length)
        {
            Console.WriteLine("The index does not exist!");
            exceptionsCount++;
            return;
        }

        Console.WriteLine(nums[index]);
    }

    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int exceptionsCount = 0;

        string command;

        while (exceptionsCount < 3)
        {
            command = Console.ReadLine();

            string[] items = command.Split(' ');

            string action = items[0];

            switch (action)
            {
                case "Replace":
                    Replace(nums, items, ref exceptionsCount);
                    break;
                case "Print":
                   Print(nums, items, ref exceptionsCount);
                    break;
                case "Show":
                    PrintAtIndex(nums, items, ref exceptionsCount);
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}