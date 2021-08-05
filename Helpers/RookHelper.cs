using sbChessMoveFinder.Enums;
using sbChessMoveFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sbChessMoveFinder.Helpers
{
    public static class RookHelper
    {
        private static Column[] columns = 
        {
            Column.a, 
            Column.b, 
            Column.c, 
            Column.d, 
            Column.e, 
            Column.f, 
            Column.g, 
            Column.h
        };

        private static int[] rows = { 1, 2, 3, 4, 5, 6, 7, 8 };

        public static List<Position> GetTilesOnSameRow(Position position)
        {
            var result = new List<Position>();
            
            foreach(var column in columns)
            {
                if (column != position.column)
                {
                    result.Add(new Position(column, position.row));
                }
            }

            return result;
        }

        public static List<Position> GetTilesOnSameColumn(Position position)
        {
            var result = new List<Position>();

            foreach (var row in rows)
            {
                if (row != position.row)
                {
                    result.Add(new Position(position.column, row));
                }
            }

            return result;
        }
    }
}
