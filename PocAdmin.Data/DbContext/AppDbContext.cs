// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<InvalidData> InvalidData { get; set; }
    public DbSet<FileEvent> FileEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvalidData>(entity =>
        {
            entity.ToTable("InvalidData");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.EffectiveDate).IsRequired();
            entity.Property(e => e.Value).HasColumnType("decimal(18,2)");
            entity.HasOne<FileEvent>().WithMany().HasForeignKey(e => e.ReferenceId);
        });

        modelBuilder.Entity<FileEvent>(entity =>
        {
            entity.ToTable("FileEvent");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FileName).IsRequired();
            entity.Property(e => e.EventDate).IsRequired();
        });
    }
}

