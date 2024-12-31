using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Infrastructure.Data;
using ApiMediaRDemo.Infrastructure.Repositories;
using ApiMediaRDemo.Models;
using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HelloMediatR.Tests.Repository;

public class PersonRepositoryTests
{
    private readonly AppDbContext _dbContext;
    private readonly PersonRepository _repository;
    private readonly ILogger<PersonRepository> _logger;

    public PersonRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(Guid.NewGuid().ToString())
        .Options;

        _dbContext = new AppDbContext(options);
        _dbContext.Database.EnsureCreated();
        _logger = A.Fake<ILogger<PersonRepository>>();

        _repository = new PersonRepository(_dbContext, _logger);

        if (_dbContext.People.Count() == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                _dbContext.People.Add(new Person
                {
                    FullName = "John Doe",
                    Age = 22
                });

                _dbContext.SaveChanges();
            }
        }
    }

    [Fact]
    public async Task PersonRepository_AddNewPersonAsync_ReturnsPersonResult()
    {
        // Arrange
        var expectedId = Guid.NewGuid();
        var newPerson = new PersonInput("Fulano de Tal", 22);
        var personResult = new PersonResult
        {
            Id = expectedId,
            FullName = "Fulano de Tal",
            Age = 22
        };

        // Act
        var result = await _repository.AddNewPersonAsync(newPerson);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data!.Id.Should().NotBeEmpty();
        result.Data.FullName.Should().Be(personResult.FullName);
        result.Data.Age.Should().Be(personResult.Age);
        result.Should().BeOfType<ServiceResponse<PersonResult>>();
    }

    [Fact]
    public async Task PersonRepository_GetAllPeopleAsync_ReturnsPeopleResult()
    {
        // Act
        var result = await _repository.GetAllPeopleAsync();

        // Assert
        result.Data.Should().NotBeNull();
        result.Data!.Count.Should().Be(10);
        result.Should().BeOfType<ServiceResponse<List<PersonResult>>>();
    }

    [Fact]
    public async Task PersonRepository_GetPersonByIdAsync_ReturnsPersonResult()
    {
        // Arrange
        var expectedId = _dbContext.People.FirstOrDefault()!.Id;
        var personResult = new PersonResult
        {
            Id = expectedId,
            FullName = "John Doe",
            Age = 22
        };

        // Act
        var result = await _repository.GetPersonByIdAsync(expectedId);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.Should().Be(personResult);
        result.Should().BeOfType<ServiceResponse<PersonResult>>();
    }

    [Fact]
    public async Task PersonRepository_UpdatePersonAsync_ReturnsPersonResult()
    {
        // Arrange
        var expectedId = _dbContext.People.LastOrDefault()!.Id;
        var updatedPerson = new PersonInput("John Smith", 33);
        var personResult = new PersonResult
        {
            Id = expectedId,
            FullName = "John Smith",
            Age = 33
        };

        // Act
        var result = await _repository.UpdatePersonAsync(expectedId, updatedPerson);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.Should().Be(personResult);
        result.Should().BeOfType<ServiceResponse<PersonResult>>();
    }

    [Fact]
    public async Task PersonRepository_RemovePersonAsync_ReturnsSucess()
    {
        // Arrange
        var expectedId = _dbContext.People.FirstOrDefault()!.Id;

        // Act
        var result = await _repository.RemovePersonAsync(expectedId);

        // Assert
        result.Success.Should().BeTrue();
        result.Should().BeOfType<ServiceResponse<bool>>();
    }
}
