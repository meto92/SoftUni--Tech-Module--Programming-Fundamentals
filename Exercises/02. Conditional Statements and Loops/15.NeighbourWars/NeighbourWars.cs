using System;

class NeighbourWars
{
    static void Main(string[] args)
    {
        string[] neighbours =
        {
            "Gosho",
            "Pesho"
        };

        int peshoHP = 100,
            goshoHP = 100,
            round = 0;

        string goshoAttack = "Thunderous fist",
            peshoAttack = "Roundhouse kick";

        int peshoDmg = int.Parse(Console.ReadLine());
        int goshoDmg = int.Parse(Console.ReadLine());

        while (true)
        {
            round++;

            string attacker = neighbours[0],
                attack = goshoAttack,
                defender = neighbours[1];

            int defenderHP;

            if (round % 2 == 0)
            {
                peshoHP -= goshoDmg;
                defenderHP = peshoHP;
            }
            else
            {
                goshoHP -= peshoDmg;
                defenderHP = goshoHP;

                attacker = neighbours[1];
                attack = peshoAttack;
                defender = neighbours[0];
            }

            if (defenderHP <= 0)
            {
                Console.WriteLine($"{attacker} won in {round}th round.");
                break;
            }

            Console.WriteLine($"{attacker} used {attack} and reduced {defender} to {defenderHP} health.");

            if (round % 3 == 0)
            {
                goshoHP += 10;
                peshoHP += 10;
            }
        }
    }
}