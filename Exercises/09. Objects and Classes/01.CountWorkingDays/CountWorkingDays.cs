using System;
using System.Globalization;

class CountWorkingDays
{
    static void Main(string[] args)
    {
        string dateFormat = "dd-MM-yyyy";

        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
            dateFormat, CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            dateFormat, CultureInfo.InvariantCulture);

        int workingDaysCount = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            int day = date.Day,
                month = date.Month;

            bool isWeekend = (int)date.DayOfWeek == 0 || (int)date.DayOfWeek == 6;
            bool isNewYearEve = month == 1 && day == 1;
            bool isLiberationDay = month == 3 && day == 3;
            bool isWorkerDay = month == 5 && day == 1;
            bool isSaintGeorgeDay = month == 5 && day == 6;
            bool isSaintsCyrilAndMethodiusDay = month == 5 && day == 24;
            bool isUnificationDay = month == 9 && day == 6;
            bool isIndependenceDay = month == 9 && day == 22;
            bool isNationalAwakeningDay = month == 11 && day == 1;
            bool isChristmas = month == 12 && (day == 24 || day == 25 || day == 26);

            if (!(isWeekend ||
                isNewYearEve ||
                isLiberationDay ||
                isWorkerDay ||
                isSaintGeorgeDay ||
                isSaintsCyrilAndMethodiusDay ||
                isUnificationDay ||
                isIndependenceDay ||
                isNationalAwakeningDay ||
                isChristmas))
            {
                workingDaysCount++;
            }
        }

        Console.WriteLine(workingDaysCount);
    }
}