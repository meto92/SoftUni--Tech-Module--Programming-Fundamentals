using System;
using System.Linq;
using System.Text.RegularExpressions;

class EmailMe
{
    static void Main(string[] args)
    {
        string email = Console.ReadLine();

        Regex pattern = new Regex(@"(.+?)@(.+?)$");

        Match match = pattern.Match(email);
        
        string leftPart = match.Groups[1].Value;
        string rightPart = match.Groups[2].Value;
        
        int leftSum = leftPart.ToArray().Sum(c => c);
        int rightSum = rightPart.ToArray().Sum(c => c);

        if (leftSum - rightSum >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}