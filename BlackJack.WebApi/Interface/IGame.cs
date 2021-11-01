using BlackJack.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Interface
{
   public interface IGame
    {
        GameCustomModel StartGame();
    }
}
