using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using sbChessMoveFinder.Enums;

namespace sbChessMoveFinder.Models
{
    public class GameState
    {
        public Affiliation turn { get; set; }
        public List<PiecePosition> piecePositions { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
