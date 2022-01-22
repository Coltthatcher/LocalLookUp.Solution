using Microsoft.EntityFrameworkCore;

namespace LocalLookUp.Models
{
    public class LocalLookUpContext : DbContext
    {
        public LocalLookUpContext(DbContextOptions<LocalLookUpContext> options)
            : base(options)
        {
        }

        public DbSet<Town> Towns { get; set; }
    }
}