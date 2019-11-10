using System;
using System.Linq;
using System.Collections.Generic;

class ChangeList
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
        string input = Console.ReadLine();

        while (input != "Odd" && input != "Even")
        {
            string[] command = input.Split(' ');
            string action = command[0];
            int element = int.Parse(command[1]);

            if (action == "Delete")
            {
                nums = nums.Where(x => x != element).ToList();
            }
            else if (action == "Insert")
            {
                int index = int.Parse(command[2]);

                if (index >= 0 && index <= nums.Count)
                {
                    nums.Insert(index, element);
                }
            }
            
            input = Console.ReadLine();
        }

        if (input == "Even")
        {
            Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0)));
        }
    }
}