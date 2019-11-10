using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CameraView
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string text = Console.ReadLine();

        int skip = nums[0],
            take = nums[1];

        Regex pattern = new Regex(@"(?<=\|<)(.*?)(?=\|<|$)");

        List<string> views = new List<string>();

        foreach (Match match in pattern.Matches(text))
        {
            string view = new string(match.Value.Skip(skip).Take(take).ToArray());

            if (view.Any())
            {
                views.Add(view);
            }
        }

        Console.WriteLine(string.Join(", ", views));
    }
}