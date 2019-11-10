using System;
using System.Linq;

class SafeManipulation
{
    static void Main(string[] args)
    {
        string[] stringArray = Console.ReadLine().Split(' ');

        string line;

        while ((line = Console.ReadLine()) != "END")
        {
            string[] command = line.Split(' ');

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

                    if (index >= 0 && index < stringArray.Length)
                    {
                        stringArray[index] = replacement;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", stringArray));
    }
}