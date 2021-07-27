using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sbChessMoveFinder.Enums;

namespace sbChessMoveFinder.Models
{
    public class Piece
    {
        public Player player { get; set; }
        public PieceType pieceType { get; set; }
        public Position boardPosition { get; set; }
    }
}
