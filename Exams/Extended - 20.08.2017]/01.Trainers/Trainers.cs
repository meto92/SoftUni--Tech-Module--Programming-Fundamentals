using System;
using System.Linq;
using System.Collections.Generic;

class Trainers
{
    static void Main(string[] args)
    {
        int participantsCount = int.Parse(Console.ReadLine());

        Dictionary<string, double> earnedMoneyByTeams = new Dictionary<string, double>()
        {
            { "Technical", 0.0},
            { "Theoretical", 0.0},
            { "Practical", 0.0}
        };

        for (int i = 0; i < participantsCount; i++)
        {
            int distanceToTravelInMiles = int.Parse(Console.ReadLine());
            double cargoInTons = double.Parse(Console.ReadLine());
            string team = Console.ReadLine();

            int distanceToTravelInMeters = distanceToTravelInMiles * 1600;
            double cargoInKilograms = cargoInTons * 1000;

            double fuelPrice = 0.7 * distanceToTravelInMeters * 2.5;
            double participantEarnedMoneyFromCargo = 1.5 * cargoInKilograms;

            double participantEarnedMoney = participantEarnedMoneyFromCargo - fuelPrice;

            earnedMoneyByTeams[team] += participantEarnedMoney;
        }

        KeyValuePair<string, double> winners = earnedMoneyByTeams.OrderByDescending(p => p.Value).First();

        string teamName = winners.Key;
        double totalEarnedTeamMoney = winners.Value;

        Console.WriteLine($"The {teamName} Trainers win with ${totalEarnedTeamMoney:f3}.");
    }
}