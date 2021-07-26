using System;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sbChessMoveFinder.Models;
using sbChessMoveFinder.Services;
using System.Collections.Generic;

namespace sbChessMoveFinder
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindMoveController : ControllerBase
    {
        private MoveService moveService;

        public FindMoveController()
        {
            this.moveService = new MoveService();
        }

        [HttpGet]
        public string findMove([FromBody] GameState gameState)
        {
            Console.WriteLine("findMove endpoint called with following game state:");
            Console.Write(gameState.ToString());

            List<Move> legalMoves = moveService.FindLegalMoves(gameState);

            List<ScoredMove> scoredMoves = moveService.ScoreMoves(legalMoves);

            var result = moveService.GetTopMoveFromList(scoredMoves);

            return JsonSerializer.Serialize(result);
        }
    }
}
