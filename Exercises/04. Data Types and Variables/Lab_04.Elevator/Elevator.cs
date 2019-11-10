using System;

class Elevator
{
    static void Main(string[] args)
    {
        int persons = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());

        int elevatorCourses = (int)Math.Ceiling((double)persons / elevatorCapacity);

        Console.WriteLine(elevatorCourses);
    }
}