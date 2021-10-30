using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class CardDeck
    {
        protected Stack<Card> Cards { get; set; } = new Stack<Card>();

        public int Count
        {
            get
            {
                return Cards.Count;
            }
        }


        public CardDeck()
        {
            var cards = new List<Card>();

            foreach (CardSuit suit
                     in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value
                         in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    //For each suit and value, 
                    //create and insert a new Card object.
                    var newCard = new Card()
                    {
                        Suit = suit,
                        Value = value
                        //ImageName = "card" + suit.GetDisplayName()
                        //            + value.GetDisplayName()
                    };

                    cards.Add(newCard);
                }
            }
        }


        ////public List<CardDeck> ShuffleCards(List<CardDeck> cards)
        ////{
        ////    var array = cards.ToArray();

        ////    Random rnd = new Random();

        ////    //Step 1: For each unshuffled item in the collection
        ////    for (int n = array.Length - 1; n > 0; --n)
        ////    {
        ////        //Step 2: Randomly pick an element 
        ////        //  which has not been shuffled
        ////        int k = rnd.Next(n + 1);

        ////        //Step 3: Swap the selected element with the 
        ////        //  last "unstruck" element in the collection
        ////        Card temp = array[n];
        ////        array[n] = array[k];
        ////        array[k] = temp;
        ////    }

        ////    //Finally, insert the now-shuffled cards into the Cards property.
        ////    for (int n = 0; n < array.Count(); n++)
        ////    {
        ////        Cards.Push(array[n]);
        ////    }
        ////}




        public void Add(Card card)
        {
            Cards.Push(card);
        }

        public Card Draw()
        {
            return Cards.Pop();
        }
    }
}
