using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sbChessMoveFinder.Models;

namespace sbChessMoveFinder.Services
{
    public class LegalityService
    {
        private GameState gs;
        private Move proposedMove;

        public bool IsMoveLegal(Move proposedMove, GameState gs)
        {
            this.gs = gs;
            this.proposedMove = proposedMove;

            switch(proposedMove.piece.pieceType)
            {
                case Enums.PieceType.pawn:
                    return isPawnMoveLegal();
                case Enums.PieceType.rook:
                    return isRookMoveLegal();
                case Enums.PieceType.bishop:
                    return isBishopMoveLegal();
                case Enums.PieceType.knight:
                    return isKnightMoveLegal();
                case Enums.PieceType.queen:
                    return isQueenMoveLegal();
                case Enums.PieceType.king:
                    return isKingMoveLegal();
                default:
                    throw new Exception();
            }
        }

        private bool isPawnMoveLegal()
        {
            return true;
        }

        private bool isRookMoveLegal()
        {
            return true;
        }

        private bool isBishopMoveLegal()
        {
            return true;
        }

        private bool isKnightMoveLegal()
        {
            return true;
        }

        private bool isQueenMoveLegal()
        {
            return true;
        }

        private bool isKingMoveLegal()
        {
            return true;
        }
    }
}
