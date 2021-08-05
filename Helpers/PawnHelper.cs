using sbChessMoveFinder.Enums;
using sbChessMoveFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sbChessMoveFinder.Helpers
{
    public static class PawnHelper
    {
        public static bool IsOnInitialTile(Position position, Player player)
        {
            if (player == Player.light && position.row == 2)
            {
                return true;
            } 
            else if (player == Player.dark && position.row == 7)
            {
                return true;
            }

            return false;
        }

        public static Position GetFirstTileInFront(Position position, Player player)
        {
            if (player == Player.light && position.row < 8)
            {
                return new Position(position.column, position.row + 1);
            }
            else if (player == Player.dark && position.row > 1)
            {
                return new Position(position.column, position.row - 1);
            }

            throw new Exception();
        }

        public static Position GetSecondTileInFront(Position position, Player player)
        {
            if (player == Player.light && position.row < 7)
            {
                return new Position(position.column, position.row + 2);
            }
            else if (player == Player.dark && position.row > 2)
            {
                return new Position(position.column, position.row - 2);
            }

            throw new Exception();
        }

        public static List<Position> GetAttackTiles(Position position, Player player)
        {
            if (player == Player.light && position.row < 8 && position.column == Column.a) 
            {
                return new List<Position>()
                {
                    new Position(position.column + 1, position.row + 1)
                };
            } 
            else if (player == Player.light && position.row < 8 && position.column == Column.h)
            {
                return new List<Position>()
                {
                    new Position(position.column - 1, position.row + 1)
                };
            }
            else if (player == Player.light && position.row < 8)
            {
                return new List<Position>()
                {
                    new Position(position.column + 1, position.row + 1),
                    new Position(position.column - 1, position.row + 1)
                };
            }

            if (player == Player.dark && position.row > 1 && position.column == Column.a)
            {
                return new List<Position>()
                {
                    new Position(position.column + 1, position.row - 1)
                };
            }
            else if (player == Player.dark && position.row > 1 && position.column == Column.h)
            {
                return new List<Position>()
                {
                    new Position(position.column - 1, position.row - 1)
                };
            }
            else if (player == Player.dark && position.row > 1)
            {
                return new List<Position>()
                {
                    new Position(position.column + 1, position.row - 1),
                    new Position(position.column - 1, position.row - 1)
                };
            }

            throw new Exception();
        }
    }
}
