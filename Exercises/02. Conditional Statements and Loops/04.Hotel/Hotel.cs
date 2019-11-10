using System;

class Hotel
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        decimal studioLevaPerNight = 68,
            doubleLevaPerNight = 77,
            suiteLevaPerNight = 89;

        switch (month)
        {
            case "May":
            case "October":
                studioLevaPerNight = 50;
                doubleLevaPerNight = 65;
                suiteLevaPerNight = 75;

                if (nightsCount > 7)
                {
                    studioLevaPerNight *= 0.95m;
                }
                break;
            case "June":
            case "September":
                studioLevaPerNight = 60;
                doubleLevaPerNight = 72;
                suiteLevaPerNight = 82;

                if (nightsCount > 14)
                {
                    doubleLevaPerNight *= 0.9m;
                }
                break;
            default:
                if (nightsCount > 14)
                {
                    suiteLevaPerNight *= 0.85m;
                }
                break;
        }

        decimal studioPrice = studioLevaPerNight * nightsCount;
        decimal doublePrice = doubleLevaPerNight * nightsCount;
        decimal suitePrice = suiteLevaPerNight * nightsCount;

        if (nightsCount > 7 && (month == "September" || month == "October"))
        {
            studioPrice -= studioLevaPerNight;
        }

        Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        Console.WriteLine($"Double: {doublePrice:f2} lv.");
        Console.WriteLine($"Suite: {suitePrice:f2} lv.");
    }
}