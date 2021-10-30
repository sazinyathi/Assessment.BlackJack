using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class Dealer : Person 
    {
        public CardDeck Deck { get; set; } = new CardDeck();

        public bool HasAceShowing => Cards.Count == 2
                                  && VisibleScore == 11
                                  && Cards.Any(x => x.IsVisible == false);
        public Card Deal()
        {
            return Deck.Draw();
        }

        public async Task DealToSelf()
        {
            await AddCard(Deal());
        }

        public async Task DealToPlayer(Player player)
        {
            await player.AddCard(Deal());
        }

    }
}
