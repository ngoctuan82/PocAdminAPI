using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<InvalidData> InvalidDataView { get; set; }
    public DbSet<FileEvent> FileEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvalidData>(entity =>
        {
            entity.ToView("vInvalidEventCA");
            entity.HasNoKey();
        });

        modelBuilder.Entity<FileEvent>(entity =>
        {
            entity.ToTable("bbg.CorporateActionFiles");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FileName).IsRequired();
            entity.Property(e => e.Directory).IsRequired();
        });
    }
}

