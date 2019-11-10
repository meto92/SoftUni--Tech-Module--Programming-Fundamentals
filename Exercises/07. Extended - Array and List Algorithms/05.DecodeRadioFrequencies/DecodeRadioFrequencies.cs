using System;
using System.Linq;

class DecodeRadioFrequencies
{
    static void Main(string[] args)
    {
        string[] doublesStr = Console.ReadLine().Split();

        char[] result = new char[doublesStr.Length * 2];


        for (int i = 0; i < doublesStr.Length; i++)
        {
            string[] parts = doublesStr[i].Split('.');
            int leftPart = int.Parse(parts[0]);
            int rightPart = int.Parse(parts[1]);

            char leftPartChar = (char)leftPart;
            char rightPartChar = (char)rightPart;

            result[i] = leftPartChar;
            result[result.Length - i - 1] = rightPartChar;
        }

        Console.WriteLine(new string(result.Where(c => c != '\0').ToArray()));
    }
}