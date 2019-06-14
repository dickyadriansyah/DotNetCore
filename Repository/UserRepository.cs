using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SupermarketAPI.Context;
using SupermarketAPI.Helpers;
using SupermarketAPI.Models;

namespace SupermarketAPI.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly AppSettings _appSettings;
        public UserRepository(AppDbContext context, IOptions<AppSettings> appSettings) : base(context)
        {
            _appSettings = appSettings.Value;
        }

        public  gt_para_user Authentication(string username, string password)
        {
            #pragma warning disable EF1000 // Possible SQL injection vulnerability.
            var user = _context.gt_para_user.FromSql("select * from gt_para_user where username='" + username + "' and password='" + password + "'").FirstOrDefault();
            #pragma warning restore EF1000 // Possible SQL injection vulnerability.

            if (user == null)
                return null;

            //authentication generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, user.id
                    .ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.token= tokenHandler.WriteToken(token);

            //update user
            

            //remove password before returning
            user.password = null;

            return user;
        }

        public async Task<List<gt_para_user>> getAllUsers()
        {
            return await _context.gt_para_user.ToListAsync();
        }
    }
}
