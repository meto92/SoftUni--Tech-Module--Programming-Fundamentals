using System;
using System.Linq;
using System.Collections.Generic;

class VehiclePark
{
    static void Main(string[] args)
    {
        List<string> vehicles = Console.ReadLine().Split(' ').ToList();

        int soldVehicles = 0;

        string request;

        while ((request = Console.ReadLine()) != "End of customers!")
        {
            string[] items = request.Split(' ');

            int seats = int.Parse(items[2]);
            char vehicleType = char.ToLower(items[0].First());

            string vehicle = $"{vehicleType}{seats}";

            if (vehicles.Contains(vehicle))
            {
                int price = vehicleType * seats;
                vehicles.Remove(vehicle);
                soldVehicles++;

                Console.WriteLine($"Yes, sold for {price}$");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        Console.WriteLine($"Vehicles left: {string.Join(", ", vehicles)}");
        Console.WriteLine($"Vehicles sold: {soldVehicles}");
    }
}