using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class NetherRealms
{
    static int GetDemonHealth(string demon)
    {
        Regex pattern = new Regex(@"[^\d\+\-*\/\.]");

        int health = 0;

        MatchCollection matches = pattern.Matches(demon);

        foreach (Match match in matches)
        {
            health += match.Value.First();
        }

        return health;
    }

    static double GetDemonDamage(string demon)
    {
        Regex pattern = new Regex(@"(\+|\-|)(\d+\.)?\d+");

        double damage = 0;

        MatchCollection matches = pattern.Matches(demon);

        foreach (Match match in matches)
        {
            damage += double.Parse(match.Value);
        }

        damage *= Math.Pow(2, demon.Count(c => c == '*'));
        damage /= Math.Pow(2, demon.Count(c => c == '/'));

        return damage;
    }

    static void Main(string[] args)
    {
        List<string> demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToList();

        foreach (string demon in demons)
        {
            int demonHealth = GetDemonHealth(demon);
            double demonDamage = GetDemonDamage(demon);

            Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:f2} damage");
        }
    }
}