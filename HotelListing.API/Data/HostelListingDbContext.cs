using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HostelListingDbContext:DbContext 
    {
        public HostelListingDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Pista House",
                    Address="USA",
                    CountryId = 1,
                    Rating=6,
                });
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United states",
                    ShortName = "USA",
                },
                new Country
                {
                    Id = 2,
                    Name="India",
                    ShortName="IND"
                });
        }
    }
}
