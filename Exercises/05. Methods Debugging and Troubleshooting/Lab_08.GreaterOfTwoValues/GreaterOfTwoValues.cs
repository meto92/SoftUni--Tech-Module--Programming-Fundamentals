using System;

class GreaterOfTwoValues
{
    static T GetMax<T>(T value1, T value2) where T : IComparable<T>
    {
        if (value1.CompareTo(value2) == 1)
        {
            return value1;
        }

        return value2;
    }

    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        
        if (type == "int")
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(num1, num2));
        }
        else if (type == "char")
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(char1, char2));
        }
        else if (type == "string")
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(GetMax(str1, str2));
        }
    }
}