using BlackJack.Models;
using BlackJack.WebApi.Interface;
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
    public class CardController : ControllerBase
    {
        private readonly ICard _card;
        public CardController(ICard card)
        {
            _card = card;
        }

        [HttpGet("DisplayCard")]
        [SwaggerOperation(Summary = "DisplayCard ", Description = "DisplayCard")]
        public IEnumerable<Card> DisplayCard()
        {
            return _card.DisplayCard();
        }
    }
}
