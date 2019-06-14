using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Models;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Services
{
    public class ParaKecamatanService : IParaKecamatanService
    {
        private readonly IParaKecamatan _parakecamatanRepository;

        public ParaKecamatanService(IParaKecamatan parakecamatanRepository)
        {
            _parakecamatanRepository = parakecamatanRepository;
        }

        public async Task<IEnumerable<gt_para_kecamatan>> ListAsync()
        {
            return await _parakecamatanRepository.ListAsync();
        }
    }
}
