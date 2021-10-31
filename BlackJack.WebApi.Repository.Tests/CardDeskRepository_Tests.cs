using BlackJack.Models;
using BlackJack.WebApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack.WebApi.Repository.Tests
{
    [TestClass]
    public class CardDeskRepository_Tests
    {

        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        private static CardDeck GetCardDeskSuccessObject()
        {

            return new CardDeck
            {
                CountofPlayingRounds = 0,
                PlayerName = "Dealer"
            };

        }

        [TestMethod]
        public void Create_Cards_Success()
        {
            try
            {
                var cardDeskRepository = new CardDeskRepository(GetConfig());
                cardDeskRepository.CreateCards();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void DrawCard_Cards_Success()
        {
            var cardDesk = new CardDeck
            {
                CountofPlayingRounds = 0,
                PlayerName = "Dealer"
            };
            var cardDeskRepository = new CardDeskRepository(GetConfig());
            var result = cardDeskRepository.DrawCard(cardDesk);
            Assert.IsInstanceOfType(result, typeof(Hand));

        }

        [TestMethod]
        public void CardTotals_Success()
        {
            var cardDeskRepository = new CardDeskRepository(GetConfig());
            var result = cardDeskRepository.CardTotals(new int []{3,2,4 });
            Assert.AreEqual(result, 9);

        }
    }
}
