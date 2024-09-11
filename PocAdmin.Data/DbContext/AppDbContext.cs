using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<InvalidData> InvalidDataView { get; set; }
    public DbSet<FileEvent> FileEvents { get; set; }
    public DbSet<RawEvent> RawEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvalidData>(entity =>
        {
            entity.ToView("vInvalidEventCA");
            entity.HasNoKey();
        });

        modelBuilder.Entity<FileEvent>(entity =>
        {
            entity.ToTable("CorporateActionFiles","bbg");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FileName).IsRequired();
            entity.Property(e => e.Directory).IsRequired();
        });
        modelBuilder.Entity<RawEvent>(entity =>
        {
            entity.ToTable("CorporateActionV2Events","bbg");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FileSourceId);
            entity.Property(e => e.ReferenceId);
        });
    }
}

