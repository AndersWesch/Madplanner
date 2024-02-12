using Microsoft.EntityFrameworkCore;
using Models;

namespace Database;

public class DatabaseContext : DbContext 
{
    public DbSet<Ret> Retter { get; set; }
    public DbSet<Produkt> Produkter { get; set; }
    public DbSet<Ingrediens> Ingredienser { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mad_planner.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingrediens>()
        .HasKey(rp => new { rp.RetId, rp.ProduktId });

        modelBuilder.Entity<Ingrediens>()
            .HasOne(rp => rp.Ret)
            .WithMany(r => r.Ingredienser)
            .HasForeignKey(rp => rp.RetId);

        modelBuilder.Entity<Ingrediens>()
            .HasOne(rp => rp.Produkt)
            .WithMany(p => p.Ingredienser)
            .HasForeignKey(rp => rp.ProduktId);
    }
}

// How to update database
// dotnet ef migrations add migration-name
// dotnet ef database update 
