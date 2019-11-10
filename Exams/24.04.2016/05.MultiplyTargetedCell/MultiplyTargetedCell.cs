using System;
using System.Linq;

class MultiplyTargetedCell
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = dimensions[0],
            cols = dimensions[1];

        int[][] matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        int[] targetedCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int targetedCellRow = targetedCell[0],
            targetedCellCol = targetedCell[1];

        int targetedCellValue = matrix[targetedCellRow][targetedCellCol],
            sumOfNeighbours = 0;

        for (int row = targetedCellRow - 1; row <= targetedCellRow + 1; row++)
        {
            for (int col = targetedCellCol - 1; col <= targetedCellCol + 1; col++)
            {
                if (row != targetedCellRow || col != targetedCellCol)
                {
                    sumOfNeighbours += matrix[row][col];
                    matrix[row][col] *= targetedCellValue;
                }
            }
        }

        matrix[targetedCellRow][targetedCellCol] *= sumOfNeighbours;

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}