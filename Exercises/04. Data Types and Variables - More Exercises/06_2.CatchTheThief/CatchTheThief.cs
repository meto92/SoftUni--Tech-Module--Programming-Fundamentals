using System;
using System.Linq;

class CatchTheThief
{
    static void Main(string[] args)
    {
        string numeralType = Console.ReadLine();
        int numberOfIDs = int.Parse(Console.ReadLine());

        long[] IDs = new long[numberOfIDs];

        for (int i = 0; i < numberOfIDs; i++)
        {
            IDs[i] = long.Parse(Console.ReadLine());
        }

        long thiefID;

        if (numeralType == "sbyte")
        {
            thiefID = IDs.Where(x => x >= -128 && x <= 127).Max();
        }
        else if (numeralType == "int")
        {
            thiefID = IDs.Where(x => x >= int.MinValue && x <= int.MaxValue).Max();
        }
        else
        {
            thiefID = IDs.Max();
        }

        Console.WriteLine(thiefID);
    }
}