using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Models;

namespace SupermarketAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        
        public DbSet<para_koordinator> para_koordinator {get; set;}

        public DbSet<gt_para_kecamatan> gt_para_kecamatan { get; set; }

        public DbSet<mahasiswa> mahasiswa { get; set; }

        public DbSet<gt_para_user> gt_para_user { get; set; }
    }
}