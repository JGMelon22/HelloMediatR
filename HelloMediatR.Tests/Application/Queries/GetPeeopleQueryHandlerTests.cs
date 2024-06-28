using ApiMediaRDemo.Application.Handlers;
using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using FakeItEasy;
using FluentAssertions;

namespace HelloMediatR.Tests.Application.Queries;

public class GetPeeopleQueryHandlerTests
{
    private readonly IPersonRepository _personRepository;

    public GetPeeopleQueryHandlerTests()
    {
        _personRepository = A.Fake<IPersonRepository>();
    }

    [Fact]
    public async Task GetPeopleQueryHandler_Handle_ReturnsPeopleResult()
    {
        // Arrange
        var handler = new GetPeopleHandler(_personRepository);
        List<PersonResult> personResult = new List<PersonResult>
        {
            new() { Id = Guid.NewGuid(), FullName = "Laura Martinez", Age = 21 },
            new() { Id = Guid.NewGuid(), FullName = "Maria Gonzalez", Age = 20 },
            new() { Id = Guid.NewGuid(), FullName = "Isabella Hernandez", Age = 22 }
        };
        var serviceResponse = new ServiceResponse<List<PersonResult>> { Data = personResult };

        A.CallTo(() => _personRepository.GetAllPeopleAsync())
           .Returns(Task.FromResult(serviceResponse));

        var query = new GetPeopleQuery();

        // Act
        var result = await handler.Handle(query, CancellationToken.None);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data!.Count().Should().Be(3);
        A.CallTo(() => _personRepository.GetAllPeopleAsync())
            .MustHaveHappened();
    }
}