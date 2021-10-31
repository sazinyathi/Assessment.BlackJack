using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;

namespace BlackJack.WebApi.Repository
{
    public class WinningRulesRepository : IWinningRules
    {
        private readonly IConfiguration _configuration;
        private const string _aceAndPontoon = "A";
        private const int _numberOfTurnsPlayed = 5;
        private const int _busts = 21;
        private const int _closeToBlackJack = 20;
        public WinningRulesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool IsPlayerHasAceAndPontoon(Hand player)
        {
            return player.Name.Equals(_aceAndPontoon) ? false : true;

        }

        public bool IsPlayerHasFiveTurn(Hand player)
        {
            return player.NumberOfTurnsPlayed.Equals(_numberOfTurnsPlayed) && player.Total < _busts ? true : false;
        }

        public WinningRules IsBlackJack(HandCustomModel handCustomModel)
        {
            var businessRules = new WinningRules { };
            if (handCustomModel.Player.Total == _busts)
            {
                businessRules.IsPlayerBlackJack = true;
            }
            if (handCustomModel.Dealer.Total == _busts)
            {
                businessRules.IsTie = true;
                businessRules.IsDealerBlackJack = true;
            }

            return businessRules;
        }

        public WinningRules IsBusts(HandCustomModel handCustomModel )
        {
            var businessRules = new WinningRules { };
            if (handCustomModel.Dealer.Total > _busts && handCustomModel.Player.Total < _busts)
            {
                businessRules.IsDealerBusts = true;
            }

            if (handCustomModel.Dealer.Total < _busts)
            {
                businessRules.IsPlayerBusts = true;
            }
            return businessRules;
        }

        public WinningRules IsCloseToBlackJack(HandCustomModel handCustomModel)
        {
            var businessRules = new WinningRules { };
            if (handCustomModel.Player.Total == _closeToBlackJack && handCustomModel.Player.Total < _busts)
            {
                businessRules.IsPlayerCloseToBlackJack = true;
            }

            if (handCustomModel.Dealer.Total == _closeToBlackJack && handCustomModel.Dealer.Total < _busts)
            {
                businessRules.IsDealerCloseToBlackJack = true;
            }
            return businessRules;
        }
    }
}
