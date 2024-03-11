using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.GameLogic
{
    public class Player
    {
        private readonly string name;
        private readonly PieceEnum piece;

        public Player(string playerName, PieceEnum piece)
        {
            this.name = playerName;
            this.piece = piece;
            PrintPlayerDetails();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public PieceEnum Piece
        {
            get
            {
                return piece;
            }
        }

        public void PrintPlayerDetails()
        {
            Console.WriteLine($"Player {this.name} will be playing with piece {this.piece}");
        }
    }
}
