using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sbChessMoveFinder.Enums;
using sbChessMoveFinder.Helpers;
using sbChessMoveFinder.Models;

namespace sbChessMoveFinder.Services
{
    public class MovementRulesService
    {
        public List<Position> GetDestinations(PieceType pieceType, Player player, Position position)
        {
            if (pieceType == PieceType.pawn)
            {
                return GetPawnDestinations(position, player);
            }
            else if (pieceType == PieceType.rook)
            {
                return GetRookDestinations(position, player);
            }
            else if (pieceType == PieceType.bishop)
            {
                return GetBishopDestinations(position, player);
            }
            else if (pieceType == PieceType.knight)
            {
                return GetKnightDestinations(position, player);
            }
            else if (pieceType == PieceType.queen)
            {
                return GetQueenDestinations(position, player);
            }
            else if (pieceType == PieceType.king)
            {
                return GetKingDestinations(position, player);
            }

            throw new Exception();
        }

        private List<Position> GetPawnDestinations(Position position, Player player)
        {
            var result = new List<Position>();

            if (PawnHelper.IsOnInitialTile(position, player))
            {
                result.Add(PawnHelper.GetFirstTileInFront(position, player));
                result.Add(PawnHelper.GetSecondTileInFront(position, player));
            } else
            {
                result.Add(PawnHelper.GetFirstTileInFront(position, player));
            }

            result.AddRange(PawnHelper.GetAttackTiles(position, player));

            return result;
        }

        private List<Position> GetRookDestinations(Position position, Player player)
        {
            throw new Exception();
        }

        private List<Position> GetBishopDestinations(Position position, Player player)
        {
            throw new Exception();
        }

        private List<Position> GetKnightDestinations(Position position, Player player)
        {
            throw new Exception();
        }

        private List<Position> GetQueenDestinations(Position position, Player player)
        {
            throw new Exception();
        }

        private List<Position> GetKingDestinations(Position position, Player player)
        {
            throw new Exception();
        }
    }
}
