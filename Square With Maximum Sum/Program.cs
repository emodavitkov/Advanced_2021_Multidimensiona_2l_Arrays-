using System;
using System.Linq;

namespace SquarewithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];



            for (int row = 0; row < rows; row++)
            {
                int[] rawData = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rawData[col];
                }
            }

            int sumMax = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int newSquareSum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];

                    if (newSquareSum > sumMax)
                    {
                        sumMax = newSquareSum;
                        a = matrix[row, col];
                        b = matrix[row + 1, col];
                        c = matrix[row, col + 1];
                        d = matrix[row + 1, col + 1];

                    }

                }


            }
            Console.WriteLine($"{a} {c}");
            Console.WriteLine($"{b} {d}");
            Console.WriteLine(sumMax);


            //sado
            //int maxSum = int.MinValue;
            //int maxSumRow = 0;
            //int maxSumCol = 0;

            //for (int row = 0; row < rows - 1; row++)
            //{
            //    for (int col = 0; col < cols - 1; col++)
            //    {
            //        int sumCurrSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
            //        if (sumCurrSquare > maxSum)
            //        {
            //            maxSum = sumCurrSquare;
            //            maxSumRow = row;
            //            maxSumCol = col;
            //        }
            //    }
            //}

            //Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
            //Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
            //Console.WriteLine(maxSum);
        }
    }
}