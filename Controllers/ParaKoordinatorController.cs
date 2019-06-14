using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Models;
using SupermarketAPI.Services;

namespace SupermarketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParaKoordinatorController : ControllerBase
    {
        private readonly IParaKoordinatorService _parakoordinatorService;

        public ParaKoordinatorController(IParaKoordinatorService parakoordinatorService)
        {
            _parakoordinatorService = parakoordinatorService;
        }

        public async Task<IEnumerable<para_koordinator>> ListAsync()
        {
            var koordinators = await _parakoordinatorService.ListAsync();

            return koordinators;
        }
    }
}