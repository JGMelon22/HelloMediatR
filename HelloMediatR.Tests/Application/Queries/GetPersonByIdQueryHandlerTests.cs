using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Handlers;
using FakeItEasy;
using FluentAssertions;

namespace HelloMediatR.Tests.Application.Queries;

public class GetPersonByIdQueryHandlerTests
{
    private readonly IPersonRepository _personRepository;

    public GetPersonByIdQueryHandlerTests()
    {
        _personRepository = A.Fake<IPersonRepository>();
    }

    [Fact]
    public async Task GetPersonByIdQuery_Handle_ReturnsPersonResult()
    {
        // Arrange 
        Guid id = Guid.NewGuid();
        var handler = new GetPersonByIdHandler(_personRepository);
        var personResult = new PersonResult
        {
            Id = id,
            FullName = "Pedro Enrique",
            Age = 14
        };

        var serviceResponse = new ServiceResponse<PersonResult> { Data = personResult };

        A.CallTo(() => _personRepository.GetPersonByIdAsync(id))
            .Returns(Task.FromResult(serviceResponse));

        var query = new GetPersonByIdQuery(id);

        // Act 
        var result = await handler.Handle(query, CancellationToken.None);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.Should().Be(personResult);
        A.CallTo(() => _personRepository.GetPersonByIdAsync(id))
            .MustHaveHappenedOnceExactly();
    }
}