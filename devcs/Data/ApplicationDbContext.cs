using devcs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace devcs.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Etudiant> Etudiants { get; set; }
    public DbSet<Cours> Cours { get; set; }
    public DbSet<Absence> Absences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Etudiant>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
        
        modelBuilder.Entity<Absence>(entity =>
        {
            entity.HasKey(a => a.Id);

            // Relation : Une absence est liée à un étudiant
            entity.HasOne(a => a.Etudiant)
                .WithMany(e => e.Absences)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Relation : Une absence est liée à un cours
            entity.HasOne(a => a.Cours)
                .WithMany(c => c.Absences)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}