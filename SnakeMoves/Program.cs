using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            string snakeString = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            int snakeCurrentIdx = 0;

            for (int row = 0; row < rows; row++)
            {


                for (int col = 0; col < cols; col++)
                {

                    if (row%2 ==0)
                    {
                        if (snakeCurrentIdx > matrix.GetLength(1))
                        {
                            snakeCurrentIdx = 0;
                        }

                        if (snakeCurrentIdx>=snakeString.Length)
                        {
                            snakeCurrentIdx = 0;
                        }
                        matrix[row, col] = snakeString[snakeCurrentIdx];
                        snakeCurrentIdx++;
                    }

                    else
                    {
                        if (snakeCurrentIdx > matrix.GetLength(1))
                        {
                            snakeCurrentIdx = 0;
                        }

                        //less
                        if (snakeCurrentIdx >= snakeString.Length)
                        {
                            snakeCurrentIdx = 0;
                        }

                        int colReverse = cols-1;
                        matrix[row, colReverse - col] = snakeString[snakeCurrentIdx];
                        snakeCurrentIdx++;

                        
                        ////matrix[row, col] = snakeString[snakeCurrentIdx];
                        //matrix[row, colReverse-col] = snakeString[snakeCurrentIdx];
                        //snakeCurrentIdx++;
                    }
                   
                }

                
            }

            PrintMatrix(matrix);
            
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
