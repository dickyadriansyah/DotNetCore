using SupermarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Services
{
    public interface IParaKecamatanService
    {
        Task<IEnumerable<gt_para_kecamatan>> ListAsync();
    }
}
