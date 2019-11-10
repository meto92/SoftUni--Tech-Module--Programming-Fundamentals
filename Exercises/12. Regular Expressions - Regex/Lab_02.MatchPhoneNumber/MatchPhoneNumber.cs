using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");

        string phoneNumbers = Console.ReadLine();

        MatchCollection matchedPhoneNumbers = pattern.Matches(phoneNumbers);
        
        Console.WriteLine(string.Join(", ", matchedPhoneNumbers.Cast<Match>().Select(m => m.Value)));
    }
}