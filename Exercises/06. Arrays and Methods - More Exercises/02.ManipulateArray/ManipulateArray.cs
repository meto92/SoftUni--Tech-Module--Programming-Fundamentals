using System;
using System.Linq;

class ManipulateArray
{
    static void Main(string[] args)
    {
        string[] stringArray = Console.ReadLine().Split(' ');
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] command = Console.ReadLine().Split(' ');

            string action = command[0];

            switch (action)
            {
                case "Reverse":
                    Array.Reverse(stringArray);
                    break;
                case "Distinct":
                    stringArray = stringArray.Distinct().ToArray();
                    break;
                case "Replace":
                    int index = int.Parse(command[1]);
                    string replacement = command[2];
                       stringArray[index] = replacement;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", stringArray));
    }
}