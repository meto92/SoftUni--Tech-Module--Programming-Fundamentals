using System;
using System.Linq;
using System.Collections.Generic;

class Person
{
    private string name;
    private string id;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public override string ToString()
    {
        return $"{name} with ID: {id} is {age} years old.";
    }
}

class OrderByAge
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] items = input.Split(' ');

            string name = items[0];
            string id = items[1];
            int age = int.Parse(items[2]);

            Person person = new Person(name, id, age);

            people.Add(person);
        }

        foreach (Person person in people.OrderBy(p => p.Age))
        {
            Console.WriteLine(person);
        }
    }
}