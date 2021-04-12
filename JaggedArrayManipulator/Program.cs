using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            //origin approach to fill the jagged matrix up

            //for (int row = 0; row < n; row++)
            //{
            //    int[] currRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //    jaggedMatrix[row] = new int[currRow.Length];

            //    for (int col = 0; col < currRow.Length; col++)
            //    {
            //        jaggedMatrix[row][col] = currRow[col];
            //    }
            //}

            //second approach # better one:
            for (int row = 0; row < rows; row++)
            {
                double[] currRow = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[row] = new double[currRow.Length];
                for (int col = 0; col < currRow.Length; col++)
                {
                    matrix[row] = currRow;
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitedCommand = command.Split();
                int row = int.Parse(splitedCommand[1]);
                int col = int.Parse(splitedCommand[2]);
                int value = int.Parse(splitedCommand[3]);

                if (splitedCommand[0] == "Add")
                {
                    if (isValidCoordinates(row, col, matrix))
                    {
                        matrix[row][col] += value;
                    }
                }
                else
                {
                    if (isValidCoordinates(row, col, matrix))
                    {
                        matrix[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool isValidCoordinates(int row, int col, double[][] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix[row].Length;
        }
    }
}
