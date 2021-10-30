using BlackJack.Interfaces;
using BlackJack.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJack.Repository
{
    public class CardRepository :ICard
    {
        private readonly IConfiguration _configuration;

        public CardRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<Card>> GetAllAsync()
        {
            var n =  new List<Card>();
            return n;
        }
    }
}
