using Microsoft.EntityFrameworkCore;

namespace Monster.Data
{
    public class MonsterDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MonsterDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MonsterDB"));
        }

        public DbSet<Monster> Employees { get; set; }
    }
}
