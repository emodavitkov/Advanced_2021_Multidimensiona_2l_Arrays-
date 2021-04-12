using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];



            for (int row = 0; row < rows; row++)
            {
                int[] rawData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rawData[col];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sumCurrSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] 
                                      + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row +1 , col + 2]
                                      + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sumCurrSquare > maxSum)
                    {
                        maxSum = sumCurrSquare;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]} {matrix[maxSumRow, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]} {matrix[maxSumRow + 1, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 2, maxSumCol]} {matrix[maxSumRow + 2, maxSumCol + 1]} {matrix[maxSumRow + 2, maxSumCol + 2]}");

            //for (int i = maxRowIndex; i < maxRowIndex + 3; i++)
            //{
            //    for (int j = maxColIndex; j < maxColIndex + 3; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
