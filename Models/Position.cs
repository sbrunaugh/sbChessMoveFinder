using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sbChessMoveFinder.Enums;

namespace sbChessMoveFinder.Models
{
    public class Position
    {
        public Column column { get; set; }
        public int row { get; set; }

        public Position (Column column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public override string ToString()
        {
            return column.ToString() + row.ToString();
        }
    }
}
