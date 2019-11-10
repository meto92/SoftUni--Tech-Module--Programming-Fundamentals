using System;
using System.Linq;
using System.Text;

class SumBigNumbers
{
    static string Sum(string firstNum, string secondNum)
    {
        int longerNumberLength = Math.Max(firstNum.Length, secondNum.Length);

        StringBuilder result = new StringBuilder(new string('0', longerNumberLength + 1));

        firstNum = firstNum.PadLeft(longerNumberLength + 1, '0');
        secondNum = secondNum.PadLeft(longerNumberLength + 1, '0');

        for (int i = longerNumberLength; i > 0; i--)
        {
            int sum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + int.Parse(result[i].ToString());

            string sumStr = sum.ToString().PadLeft(2, '0');

            result[i] = sumStr[1];
            result[i - 1] = sumStr[0];
        }

        return result.ToString().TrimStart('0');
    }

    static void Main(string[] args)
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();

        Console.WriteLine(Sum(firstNum, secondNum));
    }
}