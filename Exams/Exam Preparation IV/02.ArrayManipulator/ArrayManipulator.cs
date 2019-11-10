using System;
using System.Linq;
using System.Collections.Generic;

class ArrayManipulator
{
    static void Exchange(ref int[] nums, int index)
    {
        if (index < 0 || index >= nums.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        nums = nums.Skip(index + 1).Take(nums.Length).Concat(nums.Take(index + 1)).ToArray();
    }

    static void PrintIndex(int[] nums, string type, bool isEven)
    {
        int index = -1;

        IEnumerable<int> evens = nums.Where(x => x % 2 == 0);
        IEnumerable<int> odds = nums.Where(x => x % 2 != 0);

        if (type == "max")
        {
            if (isEven)
            {
                if (evens.Any())
                {
                    index = Array.LastIndexOf(nums, evens.Max());
                }
            }
            else
            {
                if (odds.Any())
                {
                    index = Array.LastIndexOf(nums, odds.Max());
                }
            }
        }
        else
        {
            if (isEven)
            {
                if (evens.Any())
                {
                    index = Array.LastIndexOf(nums, evens.Min());
                }
            }
            else
            {
                if (odds.Any())
                {
                    index = Array.LastIndexOf(nums, odds.Min());
                }
            }
        }

        if (index == -1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    static void PrintElements(int[] nums, string type, int count, bool isEven)
    {
        if (count > nums.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int[] result;

        if (type == "first")
        {
            if (isEven)
            {
                result = nums.Where(x => x % 2 == 0).Take(count).ToArray();
            }
            else
            {
                result = nums.Where(x => x % 2 != 0).Take(count).ToArray();
            }
        }
        else
        {
            if (isEven)
            {
                result = nums.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToArray();
            }
            else
            {
                result = nums.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToArray();
            }
        }

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split();

            string action = command[0];
            bool isEven;

            switch (action)
            {
                case "exchange":
                    int index = int.Parse(command[1]);
                    Exchange(ref nums, index);
                    break;
                case "max":
                case "min":
                    isEven = command[1] == "even";
                    PrintIndex(nums, action, isEven);
                    break;
                case "first":
                case "last":
                    int count = int.Parse(command[1]);
                    isEven = command[2] == "even";
                    PrintElements(nums, action, count, isEven);
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", nums)}]");
    }
}