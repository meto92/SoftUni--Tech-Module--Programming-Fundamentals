using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine(days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}