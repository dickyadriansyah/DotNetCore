using SupermarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Services
{
    public interface IMahasiswaService
    {
        Task<List<mahasiswa>> getMahasiswas();
    }
}
