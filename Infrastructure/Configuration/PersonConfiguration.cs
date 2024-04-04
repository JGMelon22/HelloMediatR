using ApiMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiMediatRDemo.Infrastructure.Configuration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");

        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Id)
            .HasDatabaseName("Idx_Person_Id");

        builder.Property(p => p.Id)
            .HasColumnType("UNIQUEIDENTIFIER")
            .HasColumnName("PersonId")
            .ValueGeneratedOnAdd();

        builder.Property(p => p.FullName)
            .HasColumnType("VARCHAR")
            .HasColumnName("FullName")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Age)
            .HasColumnType("TINYINT")
            .HasColumnName("Age")
            .IsRequired();
    }
}