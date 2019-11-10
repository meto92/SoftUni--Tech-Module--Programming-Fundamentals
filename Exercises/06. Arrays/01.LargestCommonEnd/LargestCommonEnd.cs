using System;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstWords = Console.ReadLine().Split(' ');
        string[] secondWords = Console.ReadLine().Split(' ');

        int leftCommonEndLength = 0,
            rightCommonEndLength = 0;

        int shorterArrayLength = Math.Min(firstWords.Length, secondWords.Length);

        for (int i = 0; i < shorterArrayLength; i++)
        {
            if (firstWords[i] == secondWords[i])
            {
                leftCommonEndLength++;
            }
            else
            {
                break;
            }
        }

        for (int i = firstWords.Length - 1, j = secondWords.Length - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (firstWords[i] == secondWords[j])
            {
                rightCommonEndLength++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(Math.Max(leftCommonEndLength, rightCommonEndLength));
    }
}