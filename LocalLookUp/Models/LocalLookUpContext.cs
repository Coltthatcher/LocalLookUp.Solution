using Microsoft.EntityFrameworkCore;

namespace LocalLookUp.Models
{
    public class LocalLookUpContext : DbContext
    {
        public LocalLookUpContext(DbContextOptions<LocalLookUpContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Town>()
            .HasData(
                new Town { TownId = 1, Name = "Bakersfeild", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 2, Name = "Andalusia", Restaurant = "Dinosaur", Shop = "" },
                new Town { TownId = 3, Name = "Matilda", Restaurant = "Dinosaur", Shop = "" },
                new Town { TownId = 4, Name = "Chickasaw", Restaurant = "Shark", Shop = "" },
                new Town { TownId = 5, Name = "Bartholomew", Restaurant = "Dinosaur", Shop = "" },
                new Town { TownId = 1, Name = "Florence", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Guntersville", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Ozark", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Spokane", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Selma", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Walpi", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Yuma", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Calexio", Restaurant = "Woolly Mammoth", Shop = "7" },
                new Town { TownId = 1, Name = "Barstow", Restaurant = "Woolly Mammoth", Shop = "7" }
            );
        }
        public DbSet<Town> Towns { get; set; }
    }
}
