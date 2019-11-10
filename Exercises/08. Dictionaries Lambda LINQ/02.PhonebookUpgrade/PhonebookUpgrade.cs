using System;
using System.Collections.Generic;

class PhonebookUpgrade
{
    static void PrintContancts(SortedDictionary<string, string> phoneBook)
    {
        foreach (KeyValuePair<string, string> pair in phoneBook)
        {
            string name = pair.Key;
            string phoneNumber = phoneBook[name];

            Console.WriteLine($"{name} -> {phoneNumber}");
        }
    }

    static void Main(string[] args)
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

        string line;

        while ((line = Console.ReadLine()) != "END")
        {
            string[] items = line.Split();

            string action = items[0];

            if (action == "A")
            {
                string name = items[1];
                string phoneNumber = items[2];

                phoneBook[name] = phoneNumber;
            }
            else if (action == "S")
            {
                string name = items[1];

                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
            else if (action == "ListAll")
            {
                PrintContancts(phoneBook);
            }
        }
    }
}