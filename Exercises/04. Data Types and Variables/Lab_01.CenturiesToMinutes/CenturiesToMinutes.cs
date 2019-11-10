using System;

class CenturiesToMinutes
{
    static void Main(string[] args)
    {
        Console.Write("Centuries = ");
        uint centuries = uint.Parse(Console.ReadLine());

        uint years = 100 * centuries,
            days = (uint)(365.2422 * years);

        ulong hours = 24 * days,
             minutes = 60 * hours;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}