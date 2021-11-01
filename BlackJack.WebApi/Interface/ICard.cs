using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Interface
{
   public  interface ICard
    {
        IEnumerable<Card> DisplayCard();
    }
}
