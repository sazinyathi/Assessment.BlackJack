using BlackJack.Models;
using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Repository
{
    public class CardRepository : ICard
    {
        private readonly IConfiguration _configuration;
        public CardRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Card> DisplayCard()
        {
            var cards = new List<Card>();
            int count = 0;
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    var card = new Card { CardId = count, Value = value.ToString(), Suit = suit.ToString() };
                    cards.Add(card);
                    count = count + 1;
                }
            }
            return cards;
        }
    }
}
