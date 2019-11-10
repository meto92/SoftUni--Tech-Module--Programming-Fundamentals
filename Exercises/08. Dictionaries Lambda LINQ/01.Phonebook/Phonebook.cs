using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        string line;

        while ((line = Console.ReadLine()) != "END")
        {
            string[] items = line.Split();

            string action = items[0];
            string name = items[1];

            if (action == "A")
            {
                string phoneNumber = items[2];

                phoneBook[name] = phoneNumber;
            }
            else
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}