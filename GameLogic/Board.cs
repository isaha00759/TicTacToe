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
            for(int i= 0;i<size;i++)
            {

                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{boardSize[i, j]}");
                    Console.Write("    ");
                    
                    if(j < size -1)
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
    }
}
