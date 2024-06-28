using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Commands;
using ApiMediatRDemo.Application.Handlers;
using FakeItEasy;
using FluentAssertions;

namespace HelloMediatR.Tests.Application.Commands;

public class RemovePersonCommandHandlerTests
{
    private readonly IPersonRepository _personRepository;

    public RemovePersonCommandHandlerTests()
    {
        _personRepository = A.Fake<IPersonRepository>();
    }

    [Fact]
    public async Task RemovePersonCommandHandler_Handle_ReturnsSuccess()
    {
        // Arrange 
        Guid id = Guid.NewGuid();
        var handler = new RemovePersonHandler(_personRepository);
        var serviceResponse = new ServiceResponse<bool> { Success = true };

        A.CallTo(() => _personRepository.RemovePersonAsync(id))
            .Returns(Task.FromResult(serviceResponse));

        var command = new RemovePersonCommand(id);

        // Act 
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Success.Should().BeTrue();
        A.CallTo(() => _personRepository.RemovePersonAsync(id))
            .MustHaveHappenedOnceExactly();
    }
}