using System;
using System.Numerics;
using System.Collections.Generic;

class AnonymousDownsite
{
    static void Main(string[] args)
    {
        int affectedWebbistesCount = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());

        List<string> affectedSites = new List<string>();
        decimal totalLoss = 0;

        for (int i = 0; i < affectedWebbistesCount; i++)
        {
            string[] items = Console.ReadLine().Split(' ');

            string site = items[0];
            long siteVisits = long.Parse(items[1]);
            decimal siteCommercialPricePerVisit = decimal.Parse(items[2]);

            decimal loses = siteVisits * siteCommercialPricePerVisit;
         
            totalLoss += loses;
            affectedSites.Add(site);
        }

        BigInteger securityToken = 1;

        for (int i = 0; i < affectedWebbistesCount; i++)
        {
            securityToken *= securityKey;
        }

        Console.WriteLine(string.Join(Environment.NewLine, affectedSites));
        Console.WriteLine($"Total Loss: {totalLoss:f20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }
}