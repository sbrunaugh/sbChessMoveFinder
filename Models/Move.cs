using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace sbChessMoveFinder.Models
{
    public class Move
    {
        public string currentPosition { get; set; }
        public string newPosition { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
