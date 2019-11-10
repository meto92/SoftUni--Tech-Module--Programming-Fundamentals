using System.IO;
using System.Linq;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        Dictionary<int, int> numbersOccurrences = new Dictionary<int, int>();

        using (StreamReader reader = new StreamReader("../../Test1.txt"))
        {
            int[] numbers = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (int number in numbers)
            {
                if (!numbersOccurrences.ContainsKey(number))
                {
                    numbersOccurrences[number] = 0;
                }

                numbersOccurrences[number]++;
            }
        }

        File.WriteAllText("../../Output1.txt",
            numbersOccurrences.OrderByDescending(p => p.Value).First().Key.ToString());
    }
}