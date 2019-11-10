using System;
using System.Linq;

class CharRotation
{
    static void Main(string[] args)
    {
        char[] chars = Console.ReadLine().ToArray();
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                chars[i] = (char)(chars[i] - nums[i]);
            }
            else
            {
                chars[i] = (char)(chars[i] + nums[i]);
            }
        }

        Console.WriteLine(new string(chars));
    }
}