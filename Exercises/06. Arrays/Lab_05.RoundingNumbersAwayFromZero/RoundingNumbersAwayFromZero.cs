using System;
using System.Linq;

class RoundingNumbersAwayFromZero
{
    static double RoundNumAwayFromZero(double num)
    {
        double rounded = 0;

        if (num > 0)
        {
            if (num * 10 % 10 >= 5)
            {
                rounded = Math.Ceiling(num);
            }
            else
            {
                rounded = Math.Floor(num);
            }
        }
        else
        {
            if (Math.Abs(num) * 10 % 10 >= 5)
            {
                rounded = Math.Floor(num);
            }
            else
            {
                rounded = Math.Ceiling(num);
            }
        }

        return rounded;
    }

    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            double roundedNum = RoundNumAwayFromZero(nums[i]);

            Console.WriteLine($"{nums[i]} => {roundedNum}");
        }
    }
}