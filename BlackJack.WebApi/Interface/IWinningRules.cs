using BlackJack.Models;
using BlackJack.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Interface
{
    public interface IWinningRules
    {
        bool IsPlayerHasAceAndPontoon(Hand player);
        bool IsPlayerHasFiveTurn(Hand player);
        WinningRules IsBlackJack(HandCustomModel handCustomModel);
        WinningRules IsBusts(HandCustomModel handCustomModel);
        WinningRules IsCloseToBlackJack(HandCustomModel handCustomModel);
    }
}

