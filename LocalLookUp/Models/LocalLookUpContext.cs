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
                new Town { TownId = 1, Name = "Bakersfield", Restaurant = "BakersFelid Pub", Shop = "Karens Curiosities" },
                new Town { TownId = 2, Name = "Andalusia", Restaurant = "Dessert Pizza", Shop = "Aquari" },
                new Town { TownId = 3, Name = "Matilda", Restaurant = "Jeff's Joe Hut", Shop = "Antique 4 You" },
                new Town { TownId = 4, Name = "Chickasaw", Restaurant = "Smoked Everything", Shop = "SmokeShop" },
                new Town { TownId = 5, Name = "Bartholomew", Restaurant = "Bistro", Shop = "Avantgarde" },
                new Town { TownId = 1, Name = "Florence", Restaurant = "Miltons Wing Stop", Shop = "Capella's Cloths Bin" },
                new Town { TownId = 1, Name = "Guntersville", Restaurant = "Woolly Mammoth Burgers", Shop = "All You Need Pet Ehmporium" },
                new Town { TownId = 1, Name = "Ozark", Restaurant = "Route 64 Diner", Shop = "711" },
                new Town { TownId = 1, Name = "Spokane", Restaurant = "Grease Palace", Shop = "Guns Guns and more Guns" },
                new Town { TownId = 1, Name = "Selma", Restaurant = "Selma Sandwhich Stop", Shop = "Selma Crystals" },
                new Town { TownId = 1, Name = "Walpi", Restaurant = "Teryaki Walipi", Shop = "Surfs Up" },
                new Town { TownId = 1, Name = "Yuma", Restaurant = "Bob's Breakfast", Shop = "Put Put golf Spot" },
                new Town { TownId = 1, Name = "Calexio", Restaurant = "Gastues", Shop = "Kyras Textiles" },
                new Town { TownId = 1, Name = "Barstow", Restaurant = "Barstow College Pub", Shop = "Oran Organic" }
            );
        }
        public DbSet<Town> Towns { get; set; }
    }
}
