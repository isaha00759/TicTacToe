using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class Game
    {
        private Player player1, player2;
        private Board board;
        private int row, column;
        public Game()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            Console.WriteLine("Enter player 1 name : ");
            string name = Console.ReadLine();
            player1 = new Player(name, PieceEnum.X);

            Console.WriteLine("Enter player 2 name : ");
            name = Console.ReadLine();
            player2 = new Player(name, PieceEnum.O);

            board = new Board(3);
            board.PrintBoard();
        }

        public void StartGame()
        {
            Console.WriteLine("Enter row");
            row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter column");
            column = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{player1.Name} making move");
            board.MakeMove(player1, row, column);
            board.PrintBoard();
        }
    }
}
