using DAL.ModelDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TalentusDB : DbContext
    {
        public TalentusDB(DbContextOptions<TalentusDB> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData
            (
                new City { CityId = 1, Name = "Monterrey, Nuevo Leon, Mexico" },
                new City { CityId = 2, Name = "Monterrey, Casanare, Colombia" },
                new City { CityId = 3, Name = "Monterrey, Cortes, Honduras" },
                new City { CityId = 4, Name = "Monterrey, Bio-Bio, Chile" },
                new City { CityId = 5, Name = "Monterrey, Asturias, Spain" },
                new City { CityId = 6, Name = "Monterrey, Magdalena, Colombia" },
                new City { CityId = 7, Name = "Monterrey, Tamaulipas, Mexico" },
                new City { CityId = 8, Name = "Monterrey, Campeche, Mexico" },
                new City { CityId = 9, Name = "Monterrey, Tabasco, Mexico" },
                new City { CityId = 10, Name = "Monterrey, Chiapas, Mexico" },
                new City { CityId = 11, Name = "Monterrey, Francisco Morazan, Honduras" }
            );
        }
        

        public DbSet<City> Cities { get; set; }
    }
}
