using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Context;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository
{
    public class ParaKoordinatorRepository : BaseRepository, IParaKoordinatorRepository
    {

        public ParaKoordinatorRepository(AppDbContext context) : base (context) {}

        public async Task<IEnumerable<para_koordinator>> ListAsync()
        {
            return await _context.para_koordinator.ToListAsync();
        }
    }
}