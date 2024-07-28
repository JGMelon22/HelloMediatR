using ApiMediaRDemo.Application.Queries;

using HelloMediatR.Application.Commands;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace HelloMediatR.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IValidator<PersonInput> _personValidator;
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(IMediator mediator, IValidator<PersonInput> personValidator
        , ILogger<PeopleController> logger)
    {
        _mediator = mediator;
        _personValidator = personValidator;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPeopleAsync()
    {
        _logger.LogInformation("Request Initialized");

        var people = await _mediator.Send(new GetPeopleQuery());

        _logger.LogInformation("Request Completed | {@people}", people.Data?.Count());

        return people.Data != null && people.Data.Any()
            ? Ok(people)
            : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPersonByIdAsync(Guid id)
    {
        var person = await _mediator.Send(new GetPersonByIdQuery(id));
        return person.Data != null
            ? Ok(person)
            : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddPersonAsync(PersonInput newPerson)
    {
        ValidationResult validatorResult = await _personValidator.ValidateAsync(newPerson);
        if (!validatorResult.IsValid)
            return BadRequest(string.Join(',', validatorResult.Errors));

        var person = await _mediator.Send(new AddPersonCommand(newPerson));
        return person.Data != null
            ? Ok(person)
            : BadRequest(person);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdatePersonAsync(Guid id, PersonInput updatedPerson)
    {
        ValidationResult validatorResult = await _personValidator.ValidateAsync(updatedPerson);
        if (!validatorResult.IsValid)
            return BadRequest(string.Join(',', validatorResult.Errors));

        var person = await _mediator.Send(new UpdatePersonCommand(id, updatedPerson));
        return person.Data != null
            ? Ok(person)
            : BadRequest(person);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemovePersonAsync(Guid id)
    {
        var person = await _mediator.Send(new RemovePersonCommand(id));
        return person.Success != false
            ? NoContent()
            : BadRequest(person);
    }
}
