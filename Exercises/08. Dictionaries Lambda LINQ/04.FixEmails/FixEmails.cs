using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class FixEmails
{
    static List<string> GetNamesToRemove(Dictionary<string, string> emails)
    {
        List<string> namesToRemove = new List<string>();

        foreach (KeyValuePair<string, string> pair in emails.Where(p => p.Value.EndsWith("us", true, CultureInfo.InvariantCulture) || p.Value.EndsWith("uk", true, CultureInfo.InvariantCulture)))
        {
            string name = pair.Key;

            namesToRemove.Add(name);
        }

        return namesToRemove;
    }

    static void RemoveUnnecessaryEmails(Dictionary<string, string> emails)
    {
        List<string> namesToRemove = GetNamesToRemove(emails);

        for (int i = 0; i < namesToRemove.Count; i++)
        {
            emails.Remove(namesToRemove[i]);
        }
    }

    static void PrintLeftEmails(Dictionary<string, string> emails)
    {
        foreach (KeyValuePair<string, string> pair in emails)
        {
            string name = pair.Key;
            string email = emails[name];

            Console.WriteLine($"{name} -> {email}");
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> emails = new Dictionary<string, string>();

        string line;

        while ((line = Console.ReadLine()) != "stop")
        {
            string name = line;
            string email = Console.ReadLine();

            emails[name] = email;
        }

        RemoveUnnecessaryEmails(emails);
        PrintLeftEmails(emails);
    }
}