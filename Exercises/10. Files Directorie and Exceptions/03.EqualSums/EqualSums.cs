using System.IO;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {
        long[] nums = File.ReadAllText("../../Test5.txt").Split(' ').Select(long.Parse).ToArray();

        using (StreamWriter writer = new StreamWriter("../../Output5.txt"))
        {
            for (int i = 0; i < nums.Length; i++)
            {
                long leftSum = nums.Take(i).Sum(),
                    rightSum = nums.Skip(i + 1).Take(nums.Length).Sum();

                if (leftSum == rightSum)
                {
                    writer.WriteLine(i);

                    writer.Close();
                    return;
                }
            }

            writer.WriteLine("no");
        }
    }
}