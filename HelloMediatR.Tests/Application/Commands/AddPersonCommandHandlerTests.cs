using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using HelloMediatR.Application.Commands;
using HelloMediatR.Application.Handlers;
using FakeItEasy;
using FluentAssertions;

namespace HelloMediatR.Tests.Application.Commands;

public class AddPersonCommandHandlerTests
{
    private readonly IPersonRepository _personRepository;

    public AddPersonCommandHandlerTests()
    {
        _personRepository = A.Fake<IPersonRepository>();
    }

    [Fact]
    public async Task AddPersonCommandHandler_Handle_ReturnsPersonResult()
    {
        // Arrange 
        var newPerson = new PersonInput("Fulano de Tal", 22);
        var handler = new AddPersonHandler(_personRepository);
        var personResult = new PersonResult
        {
            Id = Guid.NewGuid(),
            FullName = "Fulano de Tal",
            Age = 22
        };
        var serviceResponse = new ServiceResponse<PersonResult> { Data = personResult };

        A.CallTo(() => _personRepository.AddNewPersonAsync(newPerson))
            .Returns(Task.FromResult(serviceResponse));

        var command = new AddPersonCommand(newPerson);

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        result.Data.Should().NotBeNull();
        result.Data.Should().Be(personResult);
        A.CallTo(() => _personRepository.AddNewPersonAsync(newPerson))
            .MustHaveHappenedOnceExactly();
    }
}