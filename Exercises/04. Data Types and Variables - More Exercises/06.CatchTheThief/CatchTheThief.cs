using System;

class CatchTheThief
{
    static void Main(string[] args)
    {
        string numeralType = Console.ReadLine();
        int numberOfIDs = int.Parse(Console.ReadLine());

        long thiefID = 0;
        decimal minDifference = long.MaxValue;

        for (int i = 0; i < numberOfIDs; i++)
        {
            long ID = long.Parse(Console.ReadLine());

            switch (numeralType)
            {
                case "sbyte":
                    if (ID >= sbyte.MinValue && ID <= sbyte.MaxValue && minDifference > sbyte.MaxValue - ID)
                    {
                        minDifference = sbyte.MaxValue - ID;
                        thiefID = ID;
                    }
                    break;
                case "int":
                    if (ID >= int.MinValue && ID <= int.MaxValue && minDifference > (decimal)int.MaxValue - ID)
                    {
                        minDifference = int.MaxValue - ID;
                        thiefID = ID;
                    }
                    break;
                case "long":
                    if (minDifference > (decimal)long.MaxValue - ID)
                    {
                        minDifference = (decimal)long.MaxValue - ID;
                        thiefID = ID;
                    }
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(thiefID);
    }
}