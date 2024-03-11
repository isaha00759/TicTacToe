using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class Board
    {
        private int size;
        private string[,] boardSize;

        public Board(int size)
        {
            this.size = size;
            boardSize = new string[size, size];
        }

        public void PrintBoard()
        {
            Console.WriteLine("Board");
            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{boardSize[i, j]}");
                    Console.Write("    ");

                    if (j < size - 1)
                        Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------");
            }
        }

        public bool MakeMove(Player player, int x, int y)
        {
            bool moveSuccessful = false;
            Console.WriteLine($"{player.Name} with piece {player.Piece} inserting value in position : {x},{y}");

            if (string.IsNullOrEmpty(boardSize[x, y]))
            {
                boardSize[x, y] = player.Piece.ToString();
                moveSuccessful = true;
            }

            return moveSuccessful;
        }

        public bool CheckWinner(int row, int column, PieceEnum piece)
        {
            bool isWinner = false;

            for (int i = 0; i < 3; i++)
            {
                if (boardSize[row, i] != piece.ToString())
                    break;
                if (i == 2)
                    isWinner = true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (boardSize[i, column] != piece.ToString())
                    break;
                if (i == 2)
                    isWinner = true;
            }

            if (row == column)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (boardSize[i, i] != piece.ToString())
                        break;
                    if (i == 2)
                        isWinner = true;
                }
            }

            if (row + column == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (boardSize[i, 2 - i] != piece.ToString())
                        break;
                    if (i == 2)
                        isWinner = true;
                }
            }
            Console.WriteLine($"{(isWinner ? $"{piece} wins" : "")}");
            return isWinner;
        }
    }
}
