using System;
using System.Linq;

class Rainer
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int steps = 0;
        int index = nums.Last();
        int[] field = nums.Take(nums.Length - 1).ToArray();

        while (true)
        {
            field = field.Select(x => --x).ToArray();

            if (field[index] == 0)
            {
                break;
            }

            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == 0)
                {
                    field[i] = nums[i];
                }
            }

            steps++;
            index = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(string.Join(" ", field));
        Console.WriteLine(steps);
    }
}