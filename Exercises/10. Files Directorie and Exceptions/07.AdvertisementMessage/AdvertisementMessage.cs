using System;
using System.IO;

class AdvertisementMessage
{
    static void Main(string[] args)
    {
        string[] phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        string[] events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        string[] cities =
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        int numberOfMessages = int.Parse(File.ReadAllText("../../Test.txt"));

        Random rnd = new Random();

        using (StreamWriter writer = new StreamWriter("../../Output.txt"))
        {
            for (int i = 0; i < numberOfMessages; i++)
            {
                string randomPhrase = phrases[rnd.Next(phrases.Length)];
                string randomEvent = events[rnd.Next(events.Length)];
                string randomAuthor = authors[rnd.Next(authors.Length)];
                string randomCity = cities[rnd.Next(cities.Length)];

                writer.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}");
            }
        }
    }
}