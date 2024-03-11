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
            bool isPlayerOneTurn = true;
            Player player;
            do
            {
                player = GetPlayer(isPlayerOneTurn);
                Console.WriteLine($"{player.Name} making move"); 

                Console.WriteLine("Enter row");
                row = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter column");
                column = Convert.ToInt16(Console.ReadLine());

                board.MakeMove(player, row, column);
                board.PrintBoard();
                isPlayerOneTurn = TogglePlayer(isPlayerOneTurn);
            } while (!board.CheckWinner(row, column, player.Piece));
        }

        public Player GetPlayer(bool isPlayerOneTurn)
        {
            Player player;
            switch(isPlayerOneTurn)
            {
                case true:
                    player = player1;
                    break;
                case false:
                    player = player2;
                    break;
                default:
                    player = null; 
                    break;
            }
            return player;
        }

        public bool TogglePlayer(bool isPlayerOneTurn)
        {
            return isPlayerOneTurn ? false : true;
        }
    }
}
