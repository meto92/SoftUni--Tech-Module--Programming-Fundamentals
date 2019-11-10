using System;
using System.Linq;

class BombNumbers
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] specialNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int specialNumber = specialNumberAndPower[0],
            specialNumberPower = specialNumberAndPower[1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == specialNumber)
            {
                nums[i] = int.MinValue;

                for (int left = i - 1, right = i + 1, count = specialNumberPower; count > 0; left--, right++, count--)
                {
                    if (left >= 0)
                    {
                        nums[left] = int.MinValue;
                    }

                    if (right < nums.Length)
                    {
                        nums[right] = int.MinValue;
                    }
                }
            }
        }

        Console.WriteLine(nums.Where(x => x != int.MinValue).Sum());
    }
}