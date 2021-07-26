using System.Collections.Generic;
using sbChessMoveFinder.Models;

namespace sbChessMoveFinder.Services
{
    public class MoveService
    {
        public List<Move> FindLegalMoves(GameState gameState)
        {
            var result = new List<Move>();

            foreach (var piecePosition in gameState.piecePositions)
            {
                switch (piecePosition.pieceType)
                {
                    case Enums.PieceType.pawn:
                        result.AddRange(FindLegalMovesForPawn(piecePosition, gameState));
                        break;
                    case Enums.PieceType.rook:
                        result.AddRange(FindLegalMovesForRook(piecePosition, gameState));
                        break;
                    case Enums.PieceType.bishop:
                        result.AddRange(FindLegalMovesForBishop(piecePosition, gameState));
                        break;
                    case Enums.PieceType.knight:
                        result.AddRange(FindLegalMovesForKnight(piecePosition, gameState));
                        break;
                    case Enums.PieceType.queen:
                        result.AddRange(FindLegalMovesForQueen(piecePosition, gameState));
                        break;
                    case Enums.PieceType.king:
                        result.AddRange(FindLegalMovesForKing(piecePosition, gameState));
                        break;
                    default:
                        throw new System.Exception();
                }
            }

            return result;
        }

        private List<Move> FindLegalMovesForPawn(PiecePosition pawnPosition, GameState gs)
        {
            return new List<Move>();
        }

        private List<Move> FindLegalMovesForRook(PiecePosition rookPosition, GameState gs)
        {
            return new List<Move>();
        }

        private List<Move> FindLegalMovesForBishop(PiecePosition bishopPosition, GameState gs)
        {
            return new List<Move>();
        }

        private List<Move> FindLegalMovesForKnight(PiecePosition knightPosition, GameState gs)
        {
            return new List<Move>();
        }

        private List<Move> FindLegalMovesForQueen(PiecePosition queenPosition, GameState gs)
        {
            return new List<Move>();
        }

        private List<Move> FindLegalMovesForKing(PiecePosition kingPosition, GameState gs)
        {
            return new List<Move>();
        }
    }
}
