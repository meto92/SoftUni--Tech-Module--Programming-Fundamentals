using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Student
{
    private string name;
    private string email;
    private DateTime registrationDte;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public DateTime RegistrationDte
    {
        get { return registrationDte; }
        set { registrationDte = value; }
    }

    public Student(string name, string email, DateTime registrationDate)
    {
        Name = name;
        Email = email;
        RegistrationDte = registrationDate;
    }

    public override string ToString()
    {
        return email;
    }
}

class TownGroups
{
    private string town;
    private int seats;
    private List<Student> allStudents;
    private List<List<Student>> groups;

    public string Town
    {
        get { return town; }
        set { town = value; }
    }

    public int Seats
    {
        get { return seats; }
        set { seats = value; }
    }

    public List<Student> AllStudents
    {
        get { return allStudents; }
        set { allStudents = value; }
    }

    public List<List<Student>> Groups
    {
        get { return groups; }
        set { groups = value; }
    }

    public TownGroups(string town, int seats)
    {
        Town = town;
        Seats = seats;
        allStudents = new List<Student>();
        Groups = new List<List<Student>>();
    }
}

class StudentGroups
{
    static void ReadAndProcessInput(SortedDictionary<string, TownGroups> groupsByTowns)
    {
        string input;
        string town = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] items;

            if (input.Contains("=>"))
            {
                items = input.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                town = items[0];

                int seats = int.Parse(items[1].Split(' ').First());

                groupsByTowns[town] = new TownGroups(town, seats);
            }
            else
            {
                items = input.Split('|');

                string studentName = items[0].Trim(' ');
                string studentEmail = items[1].Trim(' ');
                DateTime registrationDate = DateTime.ParseExact(items[2].Trim(' '), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                Student student = new Student(studentName, studentEmail, registrationDate);

                groupsByTowns[town].AllStudents.Add(student);
            }
        }
    }

    static void DistributeGroups(SortedDictionary<string, TownGroups> groupsByTowns)
    {
        foreach (KeyValuePair<string, TownGroups> pair in groupsByTowns)
        {
            string town = pair.Key;
            int seats = groupsByTowns[town].Seats;

            groupsByTowns[town].Groups.Add(new List<Student>());
            int index = 0;

            foreach (Student student in groupsByTowns[town].AllStudents.OrderBy(s => s.RegistrationDte).ThenBy(s => s.Name).ThenBy(s => s.Email))
            {
                if (groupsByTowns[town].Groups[index].Count == seats)
                {
                    groupsByTowns[town].Groups.Add(new List<Student>());
                    index++;
                }

                groupsByTowns[town].Groups[index].Add(student);
            }
        }
    }

    static void PrintResult(SortedDictionary<string, TownGroups> groupsByTowns)
    {
        int groupsCreated = groupsByTowns.Sum(p => p.Value.Groups.Count);
        int towns = groupsByTowns.Count();

        Console.WriteLine($"Created {groupsCreated} groups in {towns} towns:");

        foreach (KeyValuePair<string, TownGroups> pair in groupsByTowns)
        {
            string town = pair.Key;

            foreach (List<Student> group in groupsByTowns[town].Groups)
            {
                Console.WriteLine($"{town} => {string.Join(", ", group)}");
            }
        }
    }

    static void Main(string[] args)
    {
        SortedDictionary<string, TownGroups> groupsByTowns = new SortedDictionary<string, TownGroups>();
        
        ReadAndProcessInput(groupsByTowns);
        DistributeGroups(groupsByTowns);
        PrintResult(groupsByTowns);
    }
}