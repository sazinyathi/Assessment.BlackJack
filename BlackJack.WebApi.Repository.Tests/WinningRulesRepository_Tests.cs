using BlackJack.Models;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack.WebApi.Repository.Tests
{
    [TestClass]
    public class WinningRulesRepository_Tests
    {

        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }


        [TestMethod]
        public void IsPlayerHasFiveTurn_Success()
        {
            var hand = new Hand { Name = "TWO DIAMOND", NumberOfTurnsPlayed = 5, Player = "Dealer", Total = 12 };
            var cardDeskRepository = new WinningRulesRepository(GetConfig());
            var results = cardDeskRepository.IsPlayerHasFiveTurn(hand);
            Assert.IsTrue(results);

        }


        [TestMethod]
        public void IsBlackJack_Success()
        {
            var player = new Hand
            {
               Name ="TWO SPADE",
               Total = 21,
            };
            var winningRulesRepository = new WinningRulesRepository(GetConfig());
            var result = winningRulesRepository.IsBlackJack(player,new Hand());
            Assert.IsInstanceOfType(result, typeof(WinningRules));

        }
    }
}
