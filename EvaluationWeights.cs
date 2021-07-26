using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sbChessMoveFinder
{
    public static class EvaluationWeights
    {
        public static int protectedKing { get; set; }
        public static int middleControl { get; set; }
        public static int developedPieces { get; set; }
    }
}
