using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sbChessMoveFinder.Models;
using sbChessMoveFinder.Services;

namespace sbChessMoveFinder.Controllers
{
    [Route("api/legality")]
    [ApiController]
    public class LegalityController : ControllerBase
    {
        private LegalityService legalityService;

        public LegalityController()
        {
            this.legalityService = new LegalityService();
        }

        //[HttpGet]
        //[Route("checkMove")]
        //public bool checkMove([FromBody] Move move)
        //{
        //    Console.WriteLine("legality/checkMove endpoint called with following move:");
        //    Console.Write(move.ToString());

        //    var result = legalityService.IsMoveLegal(move, );

        //    return result;
        //}
    }
}
