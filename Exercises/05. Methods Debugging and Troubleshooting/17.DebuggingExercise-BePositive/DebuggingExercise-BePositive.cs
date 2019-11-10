using System;
using System.Collections.Generic;

class DebuggingExercise_BePositive
{
    static void Main(string[] args)
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                int num = int.Parse(input[j]);
                numbers.Add(num);
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else if (currentNum < 0 && j < numbers.Count - 1)
                {
                    currentNum += numbers[j + 1];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }

                    j++;
                }
            }

            if (!found)
            {
                Console.Write("(empty)");
            }

            Console.WriteLine();
        }
    }
}