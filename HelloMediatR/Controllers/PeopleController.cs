using ApiMediaRDemo.Application.Queries;

using HelloMediatR.Application.Commands;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HelloMediatR.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IValidator<PersonRequest> _personValidator;

    public PeopleController(IMediator mediator, IValidator<PersonRequest> personValidator)
    {
        _mediator = mediator;
        _personValidator = personValidator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPeopleAsync()
    {
        var people = await _mediator.Send(new GetPeopleQuery());
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
    public async Task<IActionResult> AddPersonAsync(PersonRequest newPerson)
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
    public async Task<IActionResult> UpdatePersonAsync(Guid id, PersonRequest updatedPerson)
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
