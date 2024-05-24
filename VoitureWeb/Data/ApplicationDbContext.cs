using Microsoft.EntityFrameworkCore;
using VoitureWeb.Models;

namespace VoitureWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
    }
}
