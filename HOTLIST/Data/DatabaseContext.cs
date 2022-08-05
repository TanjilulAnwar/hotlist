using Microsoft.EntityFrameworkCore;

namespace HOTLIST.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bangladesh",
                    ShortName = "BD"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "India",
                     ShortName = "IND"
                 },
                 new Country
                 {
                     Id = 3,
                     Name = "Bahamas",
                     ShortName = "BS"
                 }
            );

            builder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Mariott Hotel",
                Address = "Dhaka, Bangladesh",
                CountryId = 1,
                Rating = 4.5
            },
             new Hotel
             {
                 Id = 2,
                 Name = "Sheraton Hotel",
                 Address = "Delhi, India",
                 CountryId = 2,
                 Rating = 4.5
             },
             new Hotel
             {
                 Id = 3,
                 Name = "Nusret Hotel",
                 Address = "Caymen, Bahamas",
                 CountryId = 3,
                 Rating = 4.5
             }
            );
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
