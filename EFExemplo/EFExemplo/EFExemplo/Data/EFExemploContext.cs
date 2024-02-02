using EFExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFExemplo.Data
{
    public class EFExemploContext : DbContext
    {
        public EFExemploContext(DbContextOptions<EFExemploContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
        public DbSet<EFExemplo.Models.Produto> Produto { get; set; } = default!;

    }
}
