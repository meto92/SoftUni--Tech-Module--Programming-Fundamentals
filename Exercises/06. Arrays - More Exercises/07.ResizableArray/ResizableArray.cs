using System;
using System.Linq;

class ResizableArray
{
    static void Push(ref int?[] nums, int number)
    {
        if (nums.All(x => x != null))
        {
            int?[] temp = new int?[2 * nums.Length];
            Array.Copy(nums, temp, nums.Length);
            nums = temp;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == null)
            {
                nums[i] = number;
                return;
            }
        }
    }

    static void Pop(int?[] nums)
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] != null)
            {
                nums[i] = null;
                return;
            }
        }
    }

    static void RemoveAt(ref int?[] nums, int index)
    {
        if (index < 0 || index >= nums.Length)
        {
            return;
        }

        for (int i = index; i < nums.Length - 1 && nums[i] != null; i++)
        {
            nums[i] = nums[i + 1];
        }

        nums[nums.Length - 1] = null;
    }

    static void Clear(ref int?[] nums)
    {
        nums = new int?[nums.Length];
    }

    static void Main(string[] args)
    {
        int?[] nums = new int?[4];
        
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] items = input.Split();

            string action = items[0];

            switch (action)
            {
                case "push":
                    int number = int.Parse(items[1]);
                    Push(ref nums, number);
                    break;
                case "pop":
                    Pop(nums);
                    break;
                case "removeAt":
                    int index = int.Parse(items[1]);
                    RemoveAt(ref nums, index);
                    break;
                case "clear":
                    Clear(ref nums);
                    break;
                default:
                    break;
            }
        }

        if (nums.All(x => x == null))
        {
            Console.WriteLine("empty array");
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums.Where(x => x != null)));
        }
    }
}