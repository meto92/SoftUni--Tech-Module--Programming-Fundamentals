using System;

class Resurrection
{
    static void Main(string[] args)
    {
        int phoenixesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < phoenixesCount; i++)
        {
            long phoenixBodyLength = long.Parse(Console.ReadLine());
            decimal phoenixBodyWidth = decimal.Parse(Console.ReadLine());
            int phoenixWingLength = int.Parse(Console.ReadLine());

            decimal yearsNeededForReincarnation = phoenixBodyLength * phoenixBodyLength * (phoenixBodyWidth
            + 2 * phoenixWingLength);

            Console.WriteLine(yearsNeededForReincarnation);
        }
    }
}