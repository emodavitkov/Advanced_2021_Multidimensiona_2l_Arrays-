using System;
using System.Linq;

namespace MatrixShuffling
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

            string[,] matrix = new string[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine()
                    .Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            while (true)
            {

                string text=Console.ReadLine();

                if (text=="END")
                {
                    break;
                }

                string[] commands = text
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];

                int delta = 0;

                switch (command)
                {
                    case "swap":
                        //swap row1 col1 row2c col2
                        int rowX = int.Parse(commands[1]);
                        int colX = int.Parse(commands[2]);
                        int rowY = int.Parse(commands[3]);
                        int colY = int.Parse(commands[4]);

                        if (rowX>rows||rowY>rows||colX>cols||colY>cols
                            || rowX < 0 || rowY < 0 || colX < 0 || colY < 0)
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }
                        else
                        {
                            delta = int.Parse(matrix[rowX, colX]);

                            matrix[rowX, colX] = matrix[rowY, colY];
                            matrix[rowY, colY] = delta.ToString();

                            for (int row = 0; row < rows; row++)
                            {
                                for (int col = 0; col < cols; col++)
                                {
                                    Console.Write(matrix[row, col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input!");
                        //continue;
                        break;
                }
            }

            
        }

       
    }
}
