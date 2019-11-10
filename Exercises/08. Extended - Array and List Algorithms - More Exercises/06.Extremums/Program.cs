using System;
using System.Linq;
using System.Text;

class Extremums
{
    static int GetMaxRotatedNum(int num)
    {
        StringBuilder numStr = new StringBuilder(num.ToString());

        string maxNumStr = numStr.ToString();
        int maxNum = Convert.ToInt32(numStr.ToString());

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            char temp = numStr[0];

            for (int j = 0; j < numStr.Length - 1; j++)
            {
                numStr[j] = numStr[j + 1];
            }

            numStr[numStr.Length - 1] = temp;

            int rotatedNum = Convert.ToInt32(numStr.ToString());

            if (rotatedNum > maxNum)
            {
                maxNum = rotatedNum;
                maxNumStr = numStr.ToString();
            }
        }

        return maxNum;
    }

    static int GetMinRotatedNum(int num)
    {
        StringBuilder numStr = new StringBuilder(num.ToString());

        string minNumStr = numStr.ToString();
        int minNum = Convert.ToInt32(numStr.ToString());

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            char temp = numStr[0];

            for (int j = 0; j < numStr.Length - 1; j++)
            {
                numStr[j] = numStr[j + 1];
            }

            numStr[numStr.Length - 1] = temp;

            int rotatedNum = Convert.ToInt32(numStr.ToString());

            if (rotatedNum < minNum)
            {
                minNum = rotatedNum;
                minNumStr = numStr.ToString();
            }
        }

        return minNum;
    }

    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isMinRequired = Console.ReadLine() == "Min";

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = isMinRequired ? GetMinRotatedNum(nums[i]) : GetMaxRotatedNum(nums[i]);
        }

        Console.WriteLine($"{string.Join(", ", nums)}\n{nums.Sum()}");
    }    
}