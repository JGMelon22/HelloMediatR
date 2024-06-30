using Bogus;
using Microsoft.EntityFrameworkCore;

namespace HelloMediatR.Infrastructure.Configuration.Seending;

public static class InitialSeeding
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var person = new Faker<ApiMediaRDemo.Models.Person>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.FullName, f => f.Name.FullName())
            .RuleFor(p => p.Age, f => f.Random.Byte(18, 90))
            .Generate(100);

        modelBuilder.Entity<ApiMediaRDemo.Models.Person>()
            .HasData(person);
    }
}