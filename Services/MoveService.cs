using System.Collections.Generic;
using System.Linq;
using sbChessMoveFinder.Models;

namespace sbChessMoveFinder.Services
{
    public class MoveService
    {
        private MovementRulesService movementRulesService;
        private EvaluationService evaluationService;
        private LegalityService legalityService;

        public MoveService()
        {
            this.movementRulesService = new MovementRulesService();
            this.evaluationService = new EvaluationService();
            this.legalityService = new LegalityService();
        }

        public List<Move> GetAllLegalMoves(GameState gameState)
        {
            var result = new List<Move>();

            foreach (var piece in gameState.pieces)
            {
                result.AddRange(GetLegalMovesForPiece(piece, gameState));
            }

            return result;
        }

        public List<ScoredMove> ScoreMoves(List<Move> legalMoves)
        {
            var result = new List<ScoredMove>();

            foreach(var unscoredMove in legalMoves)
            {
                result.Add(new ScoredMove()
                {
                    piece = unscoredMove.piece,
                    newPosition = unscoredMove.newPosition,
                    score = ScoreMove(unscoredMove)
                });
            }

            return result;
        }

        public Move GetTopMoveFromList(List<ScoredMove> scoredMoves)
        {
            int topScore = 0;

            foreach (var move in scoredMoves)
            {
                if (move.score > topScore)
                {
                    topScore = move.score;
                }
            }

            var bestMoves = scoredMoves.Where(x => x.score == topScore).ToList();

            return bestMoves.FirstOrDefault();
        }

        private List<Move> GetLegalMovesForPiece(Piece piece, GameState gs)
        {
            var destinations = movementRulesService.GetDestinations(
                piece.pieceType, piece.player, piece.boardPosition
            );

            var result = new List<Move>();

            foreach (var desination in destinations)
            {
                var proposedMove = new Move()
                {
                    piece = piece,
                    newPosition = desination
                };

                if (legalityService.IsMoveLegal(proposedMove, gs))
                {
                    result.Add(proposedMove);
                }
            }

            return result;
        }
    
        private int ScoreMove(Move unscoredMove)
        {
            //To-Do:
            //implement method using gamePositionScorerService...
            throw new System.Exception();
        }
    }
}
