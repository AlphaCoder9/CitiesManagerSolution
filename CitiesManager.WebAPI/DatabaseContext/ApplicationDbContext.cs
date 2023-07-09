using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext //Predefind class from MS
    {
        private static DbContextOptions options;

        //Adding essential DB sets.
        public ApplicationDbContext(DbContextOptions options) : base (options) 
        { 
        }
        public ApplicationDbContext()
        {

        }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City() { CityID =
                Guid.Parse("0739A798-1C11-4A61-B3AF-EDF11D02EF52"),
                CityName = "New York" 
            });
            modelBuilder.Entity<City>().HasData(new City() { CityID =
                Guid.Parse("56CFFF2B-DC1A-418D-B97A-013565F3A693"),
                CityName = "Waterbury"
            });
        }

    }
}
