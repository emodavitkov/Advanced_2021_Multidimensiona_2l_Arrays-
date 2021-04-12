using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = currRow;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splitCommand = command.Split();
                int row = int.Parse(splitCommand[1]);
                int col = int.Parse(splitCommand[2]);
                int value = int.Parse(splitCommand[3]);

                if (row >= 0 && col >= 0 && row < rows && col < jaggedArray[row].Length)
                {
                    if (splitCommand[0] == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Ïnvalid coordinates");
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}