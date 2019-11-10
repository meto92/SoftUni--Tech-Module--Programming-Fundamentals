using System;
using System.Linq;

class SentenceTheThief
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

        long prisonerID;

        if (numeralType == "sbyte")
        {
            prisonerID = IDs.Where(x => x >= -128 && x <= 127).Max();
        }
        else if (numeralType == "int")
        {
            prisonerID = IDs.Where(x => x >= int.MinValue && x <= int.MaxValue).Max();
        }
        else
        {
            prisonerID = IDs.Max();
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