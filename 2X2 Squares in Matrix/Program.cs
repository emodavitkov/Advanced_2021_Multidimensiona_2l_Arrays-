using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
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

            char[,] matrix = new char[rows, cols];



            for (int row = 0; row < rows; row++)
            {
                string[] rawData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(rawData[col]);
                }
            }

            int count = 0;
           

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {


                    if ((matrix[row, col] == matrix[row + 1, col])
                        && (matrix[row, col + 1] == matrix[row + 1, col + 1])
                        && (matrix[row + 1, col] == matrix[row, col + 1]))
                    {
                        count++;
                        
                    }

                   



                }


            }
            
                Console.WriteLine(count);
            
            
            
        }
    }
}
