using System;
using System.Linq;

class CompareCharArrays
{
    static void CompCharArrays(char[] firstCharArray, char[] secondCharArray, out char[] firstArrLexicographically, out char[] secondArrLexicographically)
    {
        int shorterArrayLength = Math.Min(firstCharArray.Length, secondCharArray.Length);

        for (int i = 0; i < shorterArrayLength; i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                firstArrLexicographically = firstCharArray;
                secondArrLexicographically = secondCharArray;

                return;
            }
            else if (secondCharArray[i] < firstCharArray[i])
            {
                firstArrLexicographically = secondCharArray;
                secondArrLexicographically = firstCharArray;

                return;
            }
        }

        if (firstCharArray.Length == shorterArrayLength)
        {
            firstArrLexicographically = firstCharArray;
            secondArrLexicographically = secondCharArray;
        }
        else
        {
            firstArrLexicographically = secondCharArray;
            secondArrLexicographically = firstCharArray;
        }
    }

    static void Main(string[] args)
    {
        char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        char[] firstArrLexicographically;
        char[] secondArrLexicographically;

        CompCharArrays(firstCharArray, secondCharArray, out firstArrLexicographically, out secondArrLexicographically);

        Console.WriteLine(string.Join("", firstArrLexicographically));
        Console.WriteLine(string.Join("", secondArrLexicographically));
    }
}