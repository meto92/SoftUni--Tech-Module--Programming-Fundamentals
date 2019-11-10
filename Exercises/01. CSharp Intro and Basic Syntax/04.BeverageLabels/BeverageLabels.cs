using System;

class BeverageLabels
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyContentPer100ml = int.Parse(Console.ReadLine());
        int sugarContentPer100ml = int.Parse(Console.ReadLine());

        double energyContent = volume * energyContentPer100ml / 100.0;
        double sugarContent = volume * sugarContentPer100ml / 100.0;

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
    }
}