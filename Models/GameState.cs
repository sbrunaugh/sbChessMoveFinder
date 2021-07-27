using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using sbChessMoveFinder.Enums;

namespace sbChessMoveFinder.Models
{
    public class GameState
    {
        public Player turn { get; set; }
        public List<Piece> pieces { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
