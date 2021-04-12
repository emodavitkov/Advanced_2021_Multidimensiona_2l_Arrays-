using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rawData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rawData[col];
                }
            }


            int sumLeft = 0;
            for (int i = 0; i < n; i++)
            {
                sumLeft += matrix[i, i];
            }


            int sumRight = 0;
            int padding = 0;
            bool flag = true;

            for (int row = n - 1; row >= 0; row--)
            {
                if (padding > n - 1)
                {
                    break;
                }



                for (int col = padding; col <= n - 1; col++)
                {

                    sumRight += matrix[row, col];
                    padding++;
                    if (flag == true)
                    {
                        break;
                    }


                }
            }
            int sum = Math.Abs(sumLeft - sumRight);
            Console.WriteLine(sum);


            //sado 

            //int sumFirstDiagonal = 0;
            //int sumSecondDiagonal = 0;
            //for (int i = 0; i < rowsAndCols; i++)
            //{
            //    sumFirstDiagonal += matrix[i, i];
            //    sumSecondDiagonal += matrix[rowsAndCols - i - 1, i];
            //}

            //Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}