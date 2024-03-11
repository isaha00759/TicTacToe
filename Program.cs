using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.GameLogic;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            Console.ReadKey();
        }
    }
}
