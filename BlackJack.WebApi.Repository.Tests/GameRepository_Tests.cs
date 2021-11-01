using BlackJack.Models;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack.WebApi.Repository.Tests
{
    [TestClass]
    public class GameRepository_Tests
    {

        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }


        [TestMethod]
        public void StartGame_Success()
        {
            var cardDeskRepository = new GameRepository(GetConfig());
            var results = cardDeskRepository.StartGame();
            Assert.AreEqual(results.Player.Count, 2);
            Assert.AreEqual(results.Dealers.Count, 2);

        }

    }
}
