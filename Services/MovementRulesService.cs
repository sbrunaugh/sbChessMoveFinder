using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sbChessMoveFinder.Enums;
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

            //if player is on initial tile
            //return directly in front and two in front
            //else
            //return only directly in front


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
