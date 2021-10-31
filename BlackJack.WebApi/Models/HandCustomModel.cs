using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.WebApi.Models
{
    public class HandCustomModel
    {
        public Hand Dealer { get; set; }
        public Hand Player { get; set; }
    }
}
