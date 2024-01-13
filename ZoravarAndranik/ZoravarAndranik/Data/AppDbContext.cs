using Microsoft.EntityFrameworkCore;
using ZoravarAndranik.Models;

namespace ZoravarAndranik.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dzuk> Dzuks { get; set; }
    }
}
