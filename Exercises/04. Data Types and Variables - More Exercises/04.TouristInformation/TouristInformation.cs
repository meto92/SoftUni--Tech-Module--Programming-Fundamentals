using System;

class TouristInformation
{
    static void Main(string[] args)
    {
        string imperialUnit = Console.ReadLine().ToLower();
        double imperialUnitValue = double.Parse(Console.ReadLine());

        string metricUnit = string.Empty;
        double metricUnitValue = 0;

        switch (imperialUnit)
        {
            case "miles":
                metricUnitValue = imperialUnitValue * 1.6;
                metricUnit = "kilometers";
                break;
            case "inches":
                metricUnitValue = imperialUnitValue * 2.54;
                metricUnit = "centimeters";
                break;
            case "feet":
                metricUnitValue = imperialUnitValue * 30;
                metricUnit = "centimeters";
                break;
            case "yards":
                metricUnitValue = imperialUnitValue * 0.91;
                metricUnit = "meters";
                break;
            case "gallons":
                metricUnitValue = imperialUnitValue * 3.8;
                metricUnit = "liters";
                break;
            default:
                break;
        }

        Console.WriteLine($"{imperialUnitValue} {imperialUnit} = {metricUnitValue:f2} {metricUnit}");
    }
}