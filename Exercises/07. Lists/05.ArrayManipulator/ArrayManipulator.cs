using System;
using System.Linq;
using System.Collections.Generic;

class ArrayManipulator
{
    static void AddElement(List<int> nums, string[] stringParams)
    {
        int index = int.Parse(stringParams[1]);
        int element = int.Parse(stringParams[2]);

        nums.Insert(index, element);
    }

    static void AddManyElements(List<int> nums, string[] stringParams)
    {
        int index = int.Parse(stringParams[1]);
        int[] newElements = stringParams.Skip(2).Take(stringParams.Length - 2).Select(int.Parse).ToArray();

        nums.InsertRange(index, newElements);
    }

    static void ShiftLeft(List<int> nums, int positions)
    {
        for (int r = 0; r < positions; r++)
        {
            int firstElement = nums[0];

            for (int i = 0; i < nums.Count -1; i++)
            {
                nums[i] = nums[i + 1];
            }

            nums[nums.Count - 1] = firstElement;
        }
    }

    static void SumPairs(List<int> nums)
    {
        for (int i = 0; i < nums.Count - 1; i++)
        {
            nums[i] += nums[i + 1];
            nums.RemoveAt(i + 1);
        }
    }

    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        string command;

        while ((command = Console.ReadLine()) != "print")
        {
            string[] stringParams = command.Split();

            string action = stringParams[0];

            switch (action)
            {
                case "add":
                    AddElement(nums, stringParams);
                    break;
                case "addMany":
                    AddManyElements(nums, stringParams);
                    break;
                case "contains":
                    int element = int.Parse(stringParams[1]);
                    Console.WriteLine(nums.IndexOf(element));
                    break;
                case "remove":
                    int index = int.Parse(stringParams[1]);
                    nums.RemoveAt(index);
                    break;
                case "shift":
                    int positions = int.Parse(stringParams[1]);
                    ShiftLeft(nums, positions);
                    break;
                case "sumPairs":
                    SumPairs(nums);
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", nums)}]");
    }
}