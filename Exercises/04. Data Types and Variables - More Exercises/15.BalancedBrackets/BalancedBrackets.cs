using System;

class BalancedBrackets
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        int balance = 0;

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();

            if (input == "(")
            {
                balance++;
            }
            else if (input == ")")
            {
                balance--;
            }

            if (balance < 0 || balance > 1)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
        }

        if (balance == 0)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}