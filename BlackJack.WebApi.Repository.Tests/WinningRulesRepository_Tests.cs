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
        public void IsBlackJack_Player_Success()
        {
            var model = new HandCustomModel 
            {
               Dealer = new Hand { },
               Player = new Hand { Name ="TWO DIAMOND", Total = 21, Player ="Player", NumberOfTurnsPlayed =3 }
               
            };
            var winningRulesRepository = new WinningRulesRepository(GetConfig());
            var result = winningRulesRepository.IsBlackJack(model);
            Assert.IsInstanceOfType(result, typeof(WinningRules));

        }

        [TestMethod]
        public void IsBlackJack_Dealer_Success()
        {
            var model = new HandCustomModel
            {
                Dealer = new Hand { Name = "TWO DIAMOND", Total = 21, Player = "Player", NumberOfTurnsPlayed = 3 },
                Player = new Hand { }

            };
            var winningRulesRepository = new WinningRulesRepository(GetConfig());
            var result = winningRulesRepository.IsBlackJack(model);
            Assert.IsInstanceOfType(result, typeof(WinningRules));

        }
    }
}
