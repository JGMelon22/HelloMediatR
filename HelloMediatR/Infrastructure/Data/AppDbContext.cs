using ApiMediaRDemo.Infrastructure.Configuration;
// using HelloMediatR.Infrastructure.Configuration.Seending;
using Microsoft.EntityFrameworkCore;

namespace ApiMediaRDemo.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new PersonConfiguration());

        // InitialSeeding.Seed(modelBuilder);
    }
}
