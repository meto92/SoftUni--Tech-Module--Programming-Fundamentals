using System;
using System.Linq;
using System.Collections.Generic;

class HogwartsSorting
{
    static void Main(string[] args)
    {
        int newcomersCount = int.Parse(Console.ReadLine());

        string[] houses =
        {
            "Gryffindor",
            "Slytherin",
            "Ravenclaw",
            "Hufflepuff"
        };

        Dictionary<string, int> studentsCounts = new Dictionary<string, int>
            {
                { houses[0], 0 },
                { houses[1], 0 },
                { houses[2], 0 },
                { houses[3], 0 }
            };

        for (int i = 0; i < newcomersCount; i++)
        {
            string[] studentNames = Console.ReadLine().Split(' ');

            string firstName = studentNames[0];
            string lastName = studentNames[1];

            int sum = string.Concat(firstName, lastName).ToArray().Select(ch => (int)ch).Sum();
            string house = houses[sum % 4];
            studentsCounts[house]++;

            string facultyNumber = $"{sum}{firstName.First()}{lastName.First()}";

            Console.WriteLine($"{house} {facultyNumber}");
        }

        Console.WriteLine($"{Environment.NewLine}{string.Join(Environment.NewLine, studentsCounts.Select(p => $"{p.Key}: {p.Value}"))}");
    }
}