using System;

class CenturiesToNanoseconds
{
    static void Main(string[] args)
    {
        uint centuries = uint.Parse(Console.ReadLine());

        uint years = 100 * centuries,
            days = (uint)(365.2422 * years);

        ulong hours = 24 * days,
             minutes = 60 * hours,
             seconds = 60 * minutes;

        decimal milliseconds = 1000 * seconds,
             microseconds = 1000 * milliseconds,
             nanoseconds = 1000 * microseconds;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}