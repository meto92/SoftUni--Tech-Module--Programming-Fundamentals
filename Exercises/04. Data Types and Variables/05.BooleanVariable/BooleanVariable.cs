using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        bool isTrue = Convert.ToBoolean(Console.ReadLine());

        if (isTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}