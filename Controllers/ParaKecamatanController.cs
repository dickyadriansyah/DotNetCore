using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Models;
using SupermarketAPI.Services;

namespace SupermarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParaKecamatanController : ControllerBase
    {
        private readonly IParaKecamatanService _parakecamatanService;

        public ParaKecamatanController(IParaKecamatanService parakecamatanService)
        {
            _parakecamatanService = parakecamatanService;
        }

        public async Task<IEnumerable<gt_para_kecamatan>> ListAsync()
        {
            var kecamatans = await _parakecamatanService.ListAsync();

            return kecamatans;
        }
    }
}