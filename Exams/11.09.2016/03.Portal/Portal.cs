using System;
using System.Linq;

class Portal
{
    private static char[][] room;
    private static int robotRow;
    private static int robotCol;

    static void TeleportRobotUpOrDownIfNeeded()
    {
        if (robotRow == -1)
        {
            robotRow = room.Length - 1;
        }
        else if (robotRow == room.Length)
        {
            robotRow = 0;
        }
    }

    static void MoveRobotLeft()
    {
        robotCol--;

        if (robotCol == -1)
        {
            robotCol = room[robotRow].Length - 1;
        }
    }

    static void MoveRobotRight()
    {
        robotCol++;

        if (robotCol == room[robotRow].Length)
        {
            robotCol = 0;
        }
    }

    static void MoveRobotUp()
    {
        robotRow--;
        TeleportRobotUpOrDownIfNeeded();

        while (room[robotRow].Length <= robotCol)
        {
            robotRow--;
            TeleportRobotUpOrDownIfNeeded();
        }
    }    

    static void MoveRobotDown()
    {
        robotRow++;
        TeleportRobotUpOrDownIfNeeded();

        while (room[robotRow].Length <= robotCol)
        {
            robotRow++;
            TeleportRobotUpOrDownIfNeeded();
        }
    }

    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        if (rows == 0)
        {
            return;
        }

        robotRow = -1;
        robotCol = -1;

        room = new char[rows][];

        for (int row = 0; row < rows; row++)
        {
            string rowElements = Console.ReadLine();

            room[row] = rowElements.ToCharArray();

            if (robotRow == -1 && rowElements.Contains('S'))
            {
                robotRow = row;
                robotCol = rowElements.IndexOf('S');
            }
        }

        int turns = 0;
        string directions = Console.ReadLine();

        for (; turns < directions.Length && room[robotRow][robotCol] != 'E'; turns++)
        {
            switch (directions[turns])
            {
                case 'L':
                    MoveRobotLeft();                    
                    break;
                case 'R':
                    MoveRobotRight();                    
                    break;
                case 'U':
                    MoveRobotUp();                    
                    break;
                case 'D':
                    MoveRobotDown();                    
                    break;
            }
        }

        if (room[robotRow][robotCol] == 'E')
        {
            Console.WriteLine($"Experiment successful. {turns} turns required.");
        }
        else
        {
            Console.WriteLine($"Robot stuck at {robotRow} {robotCol}. Experiment failed.");
        }
    }    
}