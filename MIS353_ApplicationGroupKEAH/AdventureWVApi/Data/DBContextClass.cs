
using AdventureWVApi.Data;
using Microsoft.EntityFrameworkCore;
namespace AdventureWVApi.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Activity> Activity { get; set; }

        public DbSet<Travelplan> Travelplan { get; set; }

        public DbSet<Hospitality> Hospitality { get; set; }

        public DbSet<Landmark> Landmark { get; set; }

        public DbSet<UserTravel> UserTravel { get; set; }
    }
}