using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Context;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository
{
    public class ParaKecamatanRepository : BaseRepository, IParaKecamatan
    {
        public ParaKecamatanRepository(AppDbContext context) : base(context){ }

        public async Task<IEnumerable<gt_para_kecamatan>> ListAsync()
        {
            return await _context.gt_para_kecamatan.ToListAsync();
        }
    }
}
