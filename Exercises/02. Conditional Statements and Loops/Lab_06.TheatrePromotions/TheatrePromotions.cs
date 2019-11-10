using System;

class TheatrePromotions
{
    static void Main(string[] args)
    {
        string dayType = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        if (age < 0 || age > 122)
        {
            Console.WriteLine("Error!");
            return;
        }

        int ticketPrice = 0;

        switch (dayType)
        {
            case "weekday":
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 12;
                }
                else
                {
                    ticketPrice = 18;
                }
                break;
            case "weekend":
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 15;
                }
                else
                {
                    ticketPrice = 20;
                }
                break;
            case "holiday":
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 12;
                }
                else
                {
                    ticketPrice = 10;
                }
                break;
            default:
                break;
        }

        Console.WriteLine($"{ticketPrice}$");
    }
}