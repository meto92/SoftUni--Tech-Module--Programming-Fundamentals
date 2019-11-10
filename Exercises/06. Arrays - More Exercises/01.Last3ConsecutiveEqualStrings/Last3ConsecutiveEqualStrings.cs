using System;
using System.Linq;

class Last3ConsecutiveEqualStrings
{
    static void Main(string[] args)
    {
        string[] strings = Console.ReadLine().Split(' ').Reverse().ToArray();

        for (int i = 0; i < strings.Length - 2; i++)
        {
            if (strings[i] == strings[i + 1] && strings[i] == strings[i + 2])
            {
                Console.WriteLine("{0} {0} {0}", strings[i]);
                break;
            }
        }
    }
}