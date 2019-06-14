using SupermarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Repository
{
    public interface IParaKecamatan
    {
        Task<IEnumerable<gt_para_kecamatan>> ListAsync();
    }
}
