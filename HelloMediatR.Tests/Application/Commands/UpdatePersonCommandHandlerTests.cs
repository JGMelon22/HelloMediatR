using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Commands;
using ApiMediatRDemo.Application.Handlers;
using FakeItEasy;
using FluentAssertions;

namespace HelloMediatR.Tests.Application.Commands;

public class UpdatePersonCommandHandlerTests
{
    private readonly IPersonRepository _personRepository;

    public UpdatePersonCommandHandlerTests()
    {
        _personRepository = A.Fake<IPersonRepository>();
    }

    [Fact]
    public async Task UpdatePersonCommandHandler_Handle_ReturnsPersonResult()
    {
        // Arrange
        Guid id = Guid.NewGuid();
        var updatedPerson = new PersonInput("Fulano de Tal", 22);
        var handler = new UpdatePersonHandler(_personRepository);
        var personResult = new PersonResult
        {
            Id = id,
            FullName = "John Doe",
            Age = 23
        };
        var serviceResponse = new ServiceResponse<PersonResult> { Data = personResult };

        A.CallTo(() => _personRepository.UpdatePersonAsync(id, updatedPerson))
            .Returns(Task.FromResult(serviceResponse));

        var command = new UpdatePersonCommand(id, updatedPerson);

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.Should().Be(personResult);
        A.CallTo(() => _personRepository.UpdatePersonAsync(id, updatedPerson))
            .MustHaveHappenedOnceExactly();
    }
}