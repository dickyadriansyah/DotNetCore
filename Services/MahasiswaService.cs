using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Models;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository _mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            _mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<List<mahasiswa>> getMahasiswas()
        {
            return await _mahasiswaRepository.getMahasiswas();
        }
    }
}
