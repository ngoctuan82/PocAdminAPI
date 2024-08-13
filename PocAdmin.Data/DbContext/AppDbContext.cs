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
        modelBuilder.Entity<InvalidData>().ToView("vInvalidData");
        modelBuilder.Entity<FileEvent>().ToView("vFileEvent");
    }
}
