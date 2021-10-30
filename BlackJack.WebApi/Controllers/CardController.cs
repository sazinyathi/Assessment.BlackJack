using BlackJack.Interfaces;
using BlackJack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICard _card;

        public CardController(ICard card)
        {
            _card = card;
        }

        [Route("GetAllAsync")]
        [HttpGet]
        [SwaggerOperation(Summary = "GetAllAsync - Returns a Lists Card", Description = "Returns a Lists Card ")]
        public async Task<List<Card>> GetAllAsync()
        {
            return await _card.GetAllAsync();
        }

    }
}

