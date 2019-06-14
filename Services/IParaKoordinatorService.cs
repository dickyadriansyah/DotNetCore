using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Models;

namespace SupermarketAPI.Services
{
    public interface IParaKoordinatorService
    {
         Task<IEnumerable<para_koordinator>> ListAsync();
    }
}