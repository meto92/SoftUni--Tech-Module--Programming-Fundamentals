using System;

class ChooseADrink2
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        decimal price = 1.2m;

        switch (profession)
        {
            case "Athlete":
                price = 0.7m;
                break;
            case "Businessman":
            case "Businesswoman":
                price = 1;
                break;
            case "SoftUni Student":
                price = 1.7m;
                break;
            default:
                break;
        }

        decimal totalPrice = price * quantity;

        Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
    }
}