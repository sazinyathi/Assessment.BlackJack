using BlackJack.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJack.Interfaces
{
    public interface ICard
    {
        Task<List<Card>> GetAllAsync();
    }
}
