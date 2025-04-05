using Microsoft.EntityFrameworkCore;
using TSD2491_oblig1_260562; // ← bytt til riktig namespace

namespace TSD2491_oblig1_260562
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options)
            : base(options)
        {
        }

        public DbSet<Bruker> Brukere { get; set; }
    }
}