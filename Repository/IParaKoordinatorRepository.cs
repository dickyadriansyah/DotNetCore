using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository
{
    public interface IParaKoordinatorRepository
    {
        Task<IEnumerable<para_koordinator>> ListAsync();
    }
}