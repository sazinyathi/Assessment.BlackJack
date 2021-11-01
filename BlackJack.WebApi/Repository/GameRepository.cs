using BlackJack.Models;
using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace BlackJack.WebApi.Repository
{
    public class GameRepository :IGame
    {
        private readonly IConfiguration _configuration;
        private readonly CardDeskRepository _cardDeskRepository;
        
        
        public GameRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _cardDeskRepository = new CardDeskRepository(configuration);
        }
        public GameCustomModel StartGame()
        {
            var playerCards = new List<Hand>();
            var dealerCards = new List<Hand>();
            var player = new CardDeck { PlayerName = "Player", CountofPlayingRounds = 0 };
            var dealer = new CardDeck { PlayerName = "Dealer", CountofPlayingRounds = 0 };

            playerCards.Add(_cardDeskRepository.DrawCard(player));
            playerCards.Add(_cardDeskRepository.DrawCard(player));
            dealerCards.Add(_cardDeskRepository.DrawCard(dealer));
            dealerCards.Add(_cardDeskRepository.DrawCard(dealer));
            var model = new GameCustomModel
            {
                Dealers = dealerCards,
                Player  = playerCards
            };

            return model;
        }
    }
}
