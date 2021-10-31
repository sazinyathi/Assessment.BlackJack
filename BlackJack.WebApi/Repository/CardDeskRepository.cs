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
    public class CardDeskRepository : ICardDesk
    {
        private readonly IConfiguration _configuration;
        private readonly List<Card> _cards;
        public CardDeskRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _cards = new List<Card>();
            CreateCards();
        }
        public int CardTotals(int[] cardNumber)
        {
            return cardNumber.Sum();
        }

        public  void CreateCards()
        {
            int count = 0;
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    var card = new Card { CardId = count, Value = value.ToString(), Suit = suit.ToString() };
                    _cards.Add(card);
                    count = count + 1;
                }
            }
        }

        public Hand DrawCard(CardDeck cardDeck)
        {
            int selectId = selectRandomCard();
            var card = _cards.Where(x => x.CardId == selectId).FirstOrDefault();
            return new Hand
            {
                Name = $"{card.Value} {card.Suit}",
                Total = ConvertToInteger(card.Value.ToString()),
                Player = cardDeck.PlayerName,
                NumberOfTurnsPlayed = cardDeck.CountofPlayingRounds
            };
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var results = string.Empty;
            for (int i = 0; i < _cards.Count; i++)
            {
                results = results + "\n" + _cards[i].ToString();
            }
            return results.ToString();
        }

        private int ConvertToInteger(string cardName)
        {
            int totalValue = 0;

            switch (cardName)
            {
                case "TWO": totalValue = totalValue + 2; break;
                case "THREE": totalValue = totalValue + 3; break;
                case "FOUR": totalValue = totalValue + 4; break;
                case "FIVE": totalValue = totalValue + 5; break;
                case "SIX": totalValue = totalValue + 6; break;
                case "SEVEN": totalValue = totalValue + 7; break;
                case "EIGHT": totalValue = totalValue + 8; break;
                case "NINE": totalValue = totalValue + 9; break;
                case "TEN": totalValue = totalValue + 10; break;
                case "JACK": totalValue = totalValue + 10; break;
                case "QUEEN": totalValue = totalValue + 10; break;
                case "KING": totalValue = totalValue + 10; break;
                case "ACE": totalValue = totalValue + 10; break;

            }
            return totalValue;
        }

        private int selectRandomCard()
        {
            var random = new Random();
            return random.Next(0, _cards.Count);

        }

    }
}
