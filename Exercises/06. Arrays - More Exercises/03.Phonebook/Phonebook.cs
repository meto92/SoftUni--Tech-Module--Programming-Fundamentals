using System;

class Phonebook
{
    static void Main(string[] args)
    {
        string[] phoneNumbers = Console.ReadLine().Split(' ');
        string[] names = Console.ReadLine().Split(' ');

        string name;

        while ((name = Console.ReadLine()) != "done")
        {
            int index = Array.IndexOf(names, name);

            Console.WriteLine($"{name} -> {phoneNumbers[index]}");
        }
    }
}