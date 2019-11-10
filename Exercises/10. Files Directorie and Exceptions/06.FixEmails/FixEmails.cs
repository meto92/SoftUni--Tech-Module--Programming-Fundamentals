using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class FixEmails
{
    static List<string> GetNamesToRemove(Dictionary<string, string> emailsByNames)
    {
        List<string> namesToRemove = new List<string>();

        foreach (KeyValuePair<string, string> pair in emailsByNames.Where(p => p.Value.EndsWith("us", true, CultureInfo.InvariantCulture) || p.Value.EndsWith("uk", true, CultureInfo.InvariantCulture)))
        {
            string name = pair.Key;

            namesToRemove.Add(name);
        }

        return namesToRemove;
    }

    static void RemoveUnnecessaryEmails(Dictionary<string, string> emailsByNames)
    {
        List<string> namesToRemove = GetNamesToRemove(emailsByNames);

        for (int i = 0; i < namesToRemove.Count; i++)
        {
            emailsByNames.Remove(namesToRemove[i]);
        }
    }

    static void SaveLeftEmails(Dictionary<string, string> emailsByNames)
    {
        File.WriteAllText("../../Output.txt",
            string.Join(Environment.NewLine, emailsByNames.Select(p => $"{p.Key} -> {p.Value}")));
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> emailsByNames = new Dictionary<string, string>();

        using (StreamReader reader = new StreamReader("../../Test.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != "stop")
            {
                string name = line;
                string email = reader.ReadLine();

                emailsByNames[name] = email;
            }
        }

        RemoveUnnecessaryEmails(emailsByNames);
        SaveLeftEmails(emailsByNames);
    }
}