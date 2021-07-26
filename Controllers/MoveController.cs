using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using sbChessMoveFinder.Models;
using sbChessMoveFinder.Services;

namespace sbChessMoveFinder
{
    [Route("api/move")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private MoveService moveService;

        public MoveController()
        {
            this.moveService = new MoveService();
        }

        [HttpGet]
        [Route("findMove")]
        public string findMove([FromBody] GameState gameState)
        {
            Console.WriteLine("move/findMove endpoint called with following game state:");
            Console.Write(gameState.ToString());

            List<Move> legalMoves = moveService.FindLegalMoves(gameState);

            List<ScoredMove> scoredMoves = moveService.ScoreMoves(legalMoves);

            var result = moveService.GetTopMoveFromList(scoredMoves);

            return JsonSerializer.Serialize(result);
        }
    }
}
