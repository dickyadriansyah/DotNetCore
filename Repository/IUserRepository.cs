using SupermarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Repository
{
    public interface IUserRepository
    {
        gt_para_user Authentication(string username, string password);

        Task<List<gt_para_user>> getAllUsers();
    }
}
