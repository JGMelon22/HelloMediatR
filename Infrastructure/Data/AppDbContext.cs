using ApiMediatRDemo.Infrastructure.Configuration;
using ApiMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMediatRDemo.Infrastructure.Data;

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
    }
}