using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Context;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository
{
    public class MahasiswaRepository : BaseRepository, IMahasiswaRepository
    {

        public MahasiswaRepository(AppDbContext context) : base(context) { }

        public async Task<List<mahasiswa>> getMahasiswas()
        {
            return await _context.mahasiswa.ToListAsync();
        }
    }
}
