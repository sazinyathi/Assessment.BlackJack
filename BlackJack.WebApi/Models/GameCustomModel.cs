using System.Collections.Generic;

namespace BlackJack.WebApi.Models
{
    public class GameCustomModel
    {
        public List<Hand> Dealers { get; set; }
        public List<Hand> Player { get; set; }
    }
}
