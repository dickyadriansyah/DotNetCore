using System.Collections.Generic;
using System.Threading.Tasks;
using SupermarketAPI.Models;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Services
{
    public class ParaKoordinatorService : IParaKoordinatorService
    {

        private readonly IParaKoordinatorRepository _parakoordinatorRepository;

        public ParaKoordinatorService(IParaKoordinatorRepository parakoordinatorRepository)
        {
            _parakoordinatorRepository = parakoordinatorRepository;
        }

        public async Task<IEnumerable<para_koordinator>> ListAsync()
        {
            return await _parakoordinatorRepository.ListAsync();
        }
    }
}