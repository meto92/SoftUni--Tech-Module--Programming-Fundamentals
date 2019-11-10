using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Student
{
    private string name;
    private List<double> grades;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<double> Grades
    {
        get { return grades; }
        set { grades = value; }
    }

    public double AverageGrade => grades.Average();

    public Student(string name, List<double> grades)
    {
        Name = name;
        Grades = grades;
    }

    public override string ToString()
    {
        return $"{name} -> {AverageGrade:f2}";
    }
}

class AverageGrades
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader("../../Test2.txt"))
        {
            int numberOfStudents = int.Parse(reader.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentParams = reader.ReadLine().Split(' ');

                string name = studentParams[0];
                List<double> grades = studentParams.
                    Skip(1).
                    Take(studentParams.Length - 1).
                    Select(double.Parse).
                    ToList();

                Student student = new Student(name, grades);

                students.Add(student);
            }
        }

        File.WriteAllText("../../Output2.txt",
            string.Join(Environment.NewLine, students.Where(s => s.AverageGrade >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade)));
    }
}