using System;

class SentenceTheThief
{
    static void Main(string[] args)
    {
        string numeralType = Console.ReadLine();
        int numberOfIDs = int.Parse(Console.ReadLine());

        long prisonerID = 0;
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
                        prisonerID = ID;
                    }
                    break;
                case "int":
                    if (ID >= int.MinValue && ID <= int.MaxValue && minDifference > (decimal)int.MaxValue - ID)
                    {
                        minDifference = int.MaxValue - ID;
                        prisonerID = ID;
                    }
                    break;
                case "long":
                    if (minDifference > (decimal)long.MaxValue - ID)
                    {
                        minDifference = (decimal)long.MaxValue - ID;
                        prisonerID = ID;
                    }
                    break;
                default:
                    break;
            }
        }

        long sentence;

        if (prisonerID < 0)
        {
            sentence = (long)Math.Ceiling(prisonerID / -128.0);
        }
        else
        {
            sentence = (long)Math.Ceiling(prisonerID / 127.0);
        }

        Console.WriteLine("Prisoner with id {0} is sentenced to {1} year{2}", prisonerID, sentence, sentence > 1 ? "s" : "");
    }
}