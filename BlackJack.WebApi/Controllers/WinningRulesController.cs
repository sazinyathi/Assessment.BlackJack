using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinningRulesController : ControllerBase
    { 

        private readonly IWinningRules _winningRules;
        public WinningRulesController(IWinningRules winningRules)
        {
            _winningRules = winningRules;
        }

        [HttpGet("IsPlayerHasAceAndPontoon")]
        [SwaggerOperation(Summary = "IsPlayerHasAceAndPontoon - Returns a bool", Description = "Returns bool")]
        public bool IsPlayerHasAceAndPontoon(Hand player)
        {
            return _winningRules.IsPlayerHasAceAndPontoon(player);
        }

        [HttpGet("IsPlayerHasFiveTurn")]
        [SwaggerOperation(Summary = "IsPlayerHasFiveTurn - Returns a bool", Description = "Returns bool")]
        public bool IsPlayerHasFiveTurn(Hand player)
        {
            return _winningRules.IsPlayerHasFiveTurn(player);
        }

        [HttpGet("IsBlackJack")]
        [SwaggerOperation(Summary = "IsBlackJack - Returns a WinningRules", Description = "Returns WinningRules")]
        public WinningRules IsBlackJack(HandCustomModel handCustomModel)
        {
            return _winningRules.IsBlackJack(handCustomModel);
        }

        [HttpGet("IsBusts")]
        [SwaggerOperation(Summary = "IsBusts - Returns a WinningRules", Description = "Returns WinningRules")]
        public WinningRules IsBusts(HandCustomModel handCustomModel)
        {
            return _winningRules.IsBusts(handCustomModel);
        }

        [HttpGet("IsCloseToBlackJack")]
        [SwaggerOperation(Summary = "IsCloseToBlackJack - Returns a WinningRules", Description = "Returns WinningRules")]
        public WinningRules IsCloseToBlackJack(HandCustomModel handCustomModel)
        {
            return _winningRules.IsBusts(handCustomModel);
        }
    }
}
