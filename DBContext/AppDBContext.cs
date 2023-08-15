using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DBContext
{
    public class AppDBContext : IdentityDbContext<AppUser, Role, int>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // new InitializeDataSeeder(builder).InsertData();

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<BookingMaster> BookingMasters { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }


    }
}
