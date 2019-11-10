using System;
using System.Linq;

class JumpAround
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int index = 0,
            steps = nums[0],
            sumOfCollectedValues = steps;

        while (true)
        {
            if (index + steps < nums.Length)
            {
                index += steps;
                steps = nums[index];
                sumOfCollectedValues += nums[index];
            }
            else if (index - steps >= 0)
            {
                index -= steps;
                steps = nums[index];
                sumOfCollectedValues += nums[index];
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sumOfCollectedValues);
    }
}