using System;
using System.Linq;

class BlurFilter
{
    static long[,] ReadMatrix(int rows, int cols)
    {
        long[,] matrix = new long[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            long[] rowEleents = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = rowEleents[col];
            }
        }

        return matrix;
    }

    static void BlurCells(long[,] matrix, int blurRow, int blurCol, int blurAmount)
    {
        int rows = matrix.GetLength(0),
            cols = matrix.GetLength(1);

        for (int row = Math.Max(blurRow - 1, 0); row <= blurRow + 1; row++)
        {
            for (int col = Math.Max(blurCol - 1, 0); col <= blurCol + 1; col++)
            {
                if (row < rows && col < cols)
                {
                    matrix[row, col] += blurAmount;
                }
            }
        }
    }

    static void PrintMatrix(long[,] matrix)
    {
        int rows = matrix.GetLength(0),
            cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }

            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int blurAmount = int.Parse(Console.ReadLine());
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = dimensions[0],
            cols = dimensions[1];

        long[,] matrix = ReadMatrix(rows, cols);

        int[] blurCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int blurRow = blurCell[0],
            blurCol = blurCell[1];

        BlurCells(matrix, blurRow, blurCol, blurAmount);
        PrintMatrix(matrix);
    }
}