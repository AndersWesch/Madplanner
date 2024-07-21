using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Database;

public class DatabaseContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Ret> Retter { get; set; }
    public DbSet<Produkt> Produkter { get; set; }
    public DbSet<Ingrediens> Ingredienser { get; set; }
    public DbSet<Madplan> Madplaner { get; set; }
    public DbSet<MadplanRet> MadplanRetter { get; set; }
    public DbSet<User> Users { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Ret <-> Produkt many to many relation (Ingrediens)
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

        // Ret <-> Madplan many to many relation (MadplanRet)
        modelBuilder.Entity<MadplanRet>()
            .HasKey(mr => new { mr.MadplanId, mr.RetId });

        modelBuilder.Entity<MadplanRet>()
            .HasOne(mr => mr.Madplan)
            .WithMany(m => m.MadplanRetter)
            .HasForeignKey(mr => mr.MadplanId);

        modelBuilder.Entity<MadplanRet>()
            .HasOne(mr => mr.Ret)
            .WithMany(r => r.MadplanRetter)
            .HasForeignKey(mr => mr.RetId);
    }
}

// How to update database
// dotnet ef migrations add migration-name
// dotnet ef database update 
