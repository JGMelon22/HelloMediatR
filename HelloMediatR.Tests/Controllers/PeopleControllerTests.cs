using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Commands;
using ApiMediatRDemo.Controllers;
using FakeItEasy;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HelloMediatR.Tests.Controllers;

public class PeopleControllerTests
{
    private readonly PeopleController _controller;
    private readonly IMediator _mediator;
    private readonly IValidator<PersonInput> _validator;

    public PeopleControllerTests()
    {
        _mediator = A.Fake<IMediator>();
        _validator = A.Fake<IValidator<PersonInput>>();

        // SUT
        _controller = new PeopleController(_mediator, _validator);
    }

    [Fact]
    public async Task PeopleController_AddPersonAsync_ReturnsPerson()
    {
        // Arrange
        var newPerson = new PersonInput("Johnny Cage", 26);
        var validationResult = new ValidationResult();
        var personResult = new PersonResult
        {
            Id = Guid.NewGuid(),
            FullName = "Johnny Cage",
            Age = 26
        };

        var serviceResponse = new ServiceResponse<PersonResult>
        {
            Data = personResult
        };

        A.CallTo(() => _validator.ValidateAsync(newPerson, default))
            .Returns(Task.FromResult(validationResult));

        A.CallTo(() => _mediator.Send(A<AddPersonCommand>.That.Matches(x => x.NewPerson == newPerson), default))
            .Returns(Task.FromResult(serviceResponse));

        // Act
        var result = await _controller.AddPersonAsync(newPerson);

        // Assert
        result.Should().NotBeNull();
        Assert.IsType<OkObjectResult>(result);
        serviceResponse.Data.Should().Be(personResult);
        result.Should().BeOfType<OkObjectResult>();
    }

    [Fact]
    public async Task PeopleController_GetAllPeopleAsync_ReturnsPeople()
    {
        // Arrange
        var peopleResult = new List<PersonResult>
        {
            new() { Id = Guid.NewGuid(), FullName = "Laura Martinez", Age = 21 },
            new() { Id = Guid.NewGuid(), FullName = "Maria Gonzalez", Age = 20 },
            new() { Id = Guid.NewGuid(), FullName = "Isabella Hernandez", Age = 22 }
        };

        var serviceResponse = new ServiceResponse<List<PersonResult>>
        {
            Data = peopleResult
        };

        A.CallTo(() => _mediator.Send(A<GetPeopleQuery>._, default))
            .Returns(Task.FromResult(serviceResponse));

        // Act
        var result = await _controller.GetAllPeopleAsync();

        // Assert
        result.Should().NotBeNull();
        Assert.IsType<OkObjectResult>(result);
        serviceResponse.Data.Count().Should().Be(3);
        result.Should().BeOfType<OkObjectResult>();
    }

    [Fact]
    public async Task PeopleController_GetPersonByIdAsync_ReturnsPerson()
    {
        // Arrange
        Guid id = Guid.NewGuid();
        var personResult = new PersonResult
        {
            Id = id,
            FullName = "Ana Beatriz",
            Age = 13
        };

        var serviceResponse = new ServiceResponse<PersonResult>
        {
            Data = personResult
        };

        A.CallTo(() => _mediator.Send(A<GetPersonByIdQuery>.That.Matches(x => x.Id == id), default))
            .Returns(Task.FromResult(serviceResponse));

        // Act 
        var result = await _controller.GetPersonByIdAsync(id);

        // Assert
        result.Should().NotBeNull();
        Assert.IsType<OkObjectResult>(result);
        serviceResponse.Data.Should().Be(personResult);
        result.Should().BeOfType<OkObjectResult>();
    }

    [Fact]
    public async Task PeopleController_UpdatePersonAsync_ReturnsPerson()
    {
        // Arrange
        Guid id = Guid.NewGuid();
        var updatedPerson = new PersonInput("Pedro Enrique", 14);
        var validationResult = new ValidationResult();
        var personResult = new PersonResult
        {
            Id = id,
            FullName = "Pedro Enrique",
            Age = 14
        };

        var serviceResponse = new ServiceResponse<PersonResult>
        {
            Data = personResult
        };

        A.CallTo(() => _validator.ValidateAsync(updatedPerson, default))
            .Returns(Task.FromResult(validationResult));

        A.CallTo(() => _mediator.Send(A<UpdatePersonCommand>.That.Matches(x => x.Id == id && x.UpdatedPerson == updatedPerson), default))
            .Returns(Task.FromResult(serviceResponse));

        // Act
        var result = await _controller.UpdatePersonAsync(id, updatedPerson);

        // Assert
        result.Should().NotBeNull();
        Assert.IsType<OkObjectResult>(result);
        serviceResponse.Data.Should().Be(personResult);
        result.Should().BeOfType<OkObjectResult>();
    }

    [Fact]
    public async Task PeopleController_RemovePersonAsync_ReturnsPerson()
    {
        // Arrange
        Guid id = Guid.NewGuid();
        var serviceResponse = new ServiceResponse<bool>();

        A.CallTo(() => _mediator.Send(A<RemovePersonCommand>.That.Matches(x => x.Id == id), default))
            .Returns(Task.FromResult(serviceResponse));

        // Act
        var result = await _controller.RemovePersonAsync(id);

        // Assert
        result.Should().NotBeNull();
        Assert.IsType<NoContentResult>(result);
        serviceResponse.Success.Should().BeTrue();
        result.Should().BeOfType<NoContentResult>();
    }
}