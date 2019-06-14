using SupermarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Repository
{
    public interface IMahasiswaRepository
    {
        Task<List<mahasiswa>> getMahasiswas();
    }
}
