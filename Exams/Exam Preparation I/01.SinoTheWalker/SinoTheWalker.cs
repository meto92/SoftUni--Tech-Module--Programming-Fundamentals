using System;
using System.Globalization;

class SinoTheWalker
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        long steps = int.Parse(Console.ReadLine());
        int stepTime = int.Parse(Console.ReadLine());

        date = date.AddSeconds(steps * stepTime % 86400);

        Console.WriteLine($"Time Arrival: {date:HH:mm:ss}");
    }
}