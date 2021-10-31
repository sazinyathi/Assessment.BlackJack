using BlackJack.Models;
using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BlackJack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardDeskController : ControllerBase
    {
        private readonly ICardDesk _cardDesk;

        public CardDeskController(ICardDesk cardDesk)
        {
            _cardDesk = cardDesk;
        }

       
        [HttpGet("DrawCard")]
        [SwaggerOperation(Summary = "DrawCard - Returns a Hand", Description = "Returns a Hand Card ")]
        public Hand DrawCard(CardDeck cardDeck)
        {
            return  _cardDesk.DrawCard(cardDeck);
        }

        [HttpGet("CardTotals")]
        [SwaggerOperation(Summary = "CardTotals - Returns a TotalCards in hand", Description = "Returns a TotalCards in hand ")]
        public int CardTotals(int[] cardNumber)
        {
            return _cardDesk.CardTotals(cardNumber);
        }

    }
}
