using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using sbChessMoveFinder.Enums;

namespace sbChessMoveFinder.Models
{
    public class Move
    {
        public Piece piece { get; set; }
        public Position newPosition { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
