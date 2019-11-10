using System;
using System.Linq;
using System.Collections.Generic;

class Vehicle
{
    private string type;
    private string model;
    private string color;
    private int horsePower;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public int HorsePower
    {
        get { return horsePower; }
        set { horsePower = value; }
    }

    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }
}

class VehicleCatalogue
{
    static void AddVehicles(Dictionary<string, List<Vehicle>> catalogue)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] items = input.Split(' ');

            string type = string.Concat(char.ToUpper(items[0].First()).ToString(), new string(items[0].Skip(1).Take(items[0].Length - 1).ToArray()).ToLower());
            string model = items[1];
            string color = items[2];
            int horsePower = int.Parse(items[3]);

            Vehicle vehicle = new Vehicle(type, model, color, horsePower);

            catalogue[type].Add(vehicle);
        }
    }

    static void PrintModelInfo(Dictionary<string, List<Vehicle>> catalogue, string model)
    {
        foreach (KeyValuePair<string, List<Vehicle>> pair in catalogue)
        {
            for (int i = 0; i < catalogue[pair.Key].Count; i++)
            {
                Vehicle vehicle = catalogue[pair.Key][i];

                if (vehicle.Model == model)
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, List<Vehicle>> catalogue = new Dictionary<string, List<Vehicle>>();

        catalogue["Car"] = new List<Vehicle>();
        catalogue["Truck"] = new List<Vehicle>();

        AddVehicles(catalogue);

        string model;

        while ((model = Console.ReadLine()) != "Close the Catalogue")
        {
            PrintModelInfo(catalogue, model);
        }

        double carsAverageHorsepowers = 0;
        double trucksAverageHorsepowers = 0;

        if (catalogue["Car"].Count > 0)
        {
            carsAverageHorsepowers = catalogue["Car"].Average(p => p.HorsePower);
        }

        if (catalogue["Truck"].Count > 0)
        {
            trucksAverageHorsepowers = catalogue["Truck"].Average(p => p.HorsePower);

        }

        Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepowers:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepowers:f2}.");
    }
}