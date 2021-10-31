using BlackJack.Models;
using BlackJack.WebApi.Models;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Interface
{
    public interface ICardDesk
    {
        void CreateCards();
        Hand DrawCard(CardDeck cardDeck);
        int CardTotals(int[] cardNumber);
        void Shuffle();
    }
}
