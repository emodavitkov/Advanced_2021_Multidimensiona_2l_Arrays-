using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardDimension = int.Parse(Console.ReadLine());
            int[,] board = new int[boardDimension, boardDimension];

            for (int row = 0; row < boardDimension; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < boardDimension; col++)
                {
                    if (currRow[col] == 'K')
                    {
                        board[row, col] = -1;
                    }
                }
            }

            int removeKnights = 0;
            while (true)
            {
                int maxAttacks = 0;
                int maxAttacksRow = 0;
                int maxAttacksCol = 0;

                for (int row = 0; row < boardDimension; row++)
                {
                    for (int col = 0; col < boardDimension; col++)
                    {
                        if (board[row, col] != 0)
                        {
                            board[row, col] = AttackKnight(row, col, board);
                            if (board[row, col] > maxAttacks)
                            {
                                maxAttacks = board[row, col];
                                maxAttacksRow = row;
                                maxAttacksCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks != 0)
                {
                    board[maxAttacksRow, maxAttacksCol] = 0;
                    removeKnights++;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine(removeKnights);
        }

        private static int AttackKnight(int row, int col, int[,] board)
        {
            int[,] allMoves = new int[8, 2]
            {
                { -2, -1 },
                { -2, 1 },
                { -1, -2 },
                { -1, 2 },
                { 2, -1 },
                { 2, 1 },
                { 1, -2 },
                { 1, 2 },
            };
            int count = 0;
            for (int moveRow = 0; moveRow < allMoves.GetLength(0); moveRow++)
            {
                int attackRow = row + allMoves[moveRow, 0];
                int attackCol = col + allMoves[moveRow, 1];

                if (IsValidCoordinates(attackRow, attackCol, board))
                {
                    if (board[attackRow, attackCol] != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static bool IsValidCoordinates(int row, int col, int[,] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
