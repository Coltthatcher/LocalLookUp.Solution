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
                new Town { TownId = 6, Name = "Florence", Restaurant = "Miltons Wing Stop", Shop = "Capella's Cloths Bin" },
                new Town { TownId = 7, Name = "Guntersville", Restaurant = "Woolly Mammoth Burgers", Shop = "All You Need Pet Emporium" },
                new Town { TownId = 8, Name = "Ozark", Restaurant = "Route 64 Diner", Shop = "711" },
                new Town { TownId = 9, Name = "Spokane", Restaurant = "Grease Palace", Shop = "Guns Guns and more Guns" },
                new Town { TownId = 10, Name = "Selma", Restaurant = "Selma Sandwhich Stop", Shop = "Selma Crystals" },
                new Town { TownId = 11, Name = "Walpi", Restaurant = "Teryaki Walipi", Shop = "Surfs Up" },
                new Town { TownId = 12, Name = "Yuma", Restaurant = "Bob's Breakfast", Shop = "Put Put golf Spot" },
                new Town { TownId = 13, Name = "Calexio", Restaurant = "Gastues", Shop = "Kyras Textiles" },
                new Town { TownId = 14, Name = "Barstow", Restaurant = "Barstow College Pub", Shop = "Oran Organic" },
                new Town { TownId = 15, Name = "Puslbo", Restaurant = "Grill King", Shop = "Orca Sounds Trinkets" },
                new Town { TownId = 16, Name = "Scottsdale", Restaurant = "Ricky's", Shop = "Duck Hunting supply" },
                new Town { TownId = 17, Name = "Marysville", Restaurant = "Mama Roo's", Shop = "Hillbit Nursery" },
                new Town { TownId = 18, Name = "San Mateo", Restaurant = "Gastues", Shop = "Kyras Textiles" },
                new Town { TownId = 19, Name = "Fall River", Restaurant = "Orion", Shop = "Beatrice Bagel" },
                new Town { TownId = 20, Name = "Groton", Restaurant = "Goreton River Grill", Shop = "Bait and Fish" },
                new Town { TownId = 21, Name = "Willmar", Restaurant = "Rebel Rouseres", Shop = "Spaghetti Factory" },
                new Town { TownId = 22, Name = "Missoula", Restaurant = "Corenell's Chicken", Shop = "Om Bap" }
            );
        }
        public DbSet<Town> Towns { get; set; }
    }
}
