using BlackJack.Models;
using System.Collections.Generic;

namespace BlackJack.WebApi.Models
{
    public class Hand
    {
        public string Name { get; set; }
        public int Total { get; set; }
        public string Player { get; set; }
        public int NumberOfTurnsPlayed { get; set; }

    }
}
