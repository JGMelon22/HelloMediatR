using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Commands;
using ApiMediatRDemo.Controllers;
using FakeItEasy;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
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

        // Act

        // Assert
    }
}