using System;

class SortArrayOfStrings
{
    static void Main(string[] args)
    {
        string[] array = Console.ReadLine().Split();

        for (int i = 1; i < array.Length; i++)
        {
            int j = i - 1;
            string temp = array[i];
            
            while (j >= 0 && array[j].CompareTo(temp)  == 1)
            {
                array[j + 1] = array[j];
                j--;
            }
            
            array[j + 1] = temp;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}