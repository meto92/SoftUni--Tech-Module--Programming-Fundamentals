using System.IO;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] nums = File.ReadAllText("../../Test3.txt").Split(' ').Select(int.Parse).ToArray();

        int startIndex = 0,
            bestStartIndex = 0,
            length = 1,
            bestLength = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[startIndex])
            {
                length++;

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStartIndex = startIndex;
                }
            }
            else
            {
                length = 1;
                startIndex = i;
            }
        }

        File.WriteAllText("../../Output3.txt", string.Join(" ", nums.Skip(bestStartIndex).Take(bestLength)));
    }
}