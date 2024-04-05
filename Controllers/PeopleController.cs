using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
using ApiMediatRDemo.Application.Commands;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiMediatRDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IValidator<PersonInput> _personValidator;

    public PeopleController(IMediator mediator, IValidator<PersonInput> personValidator)
    {
        _mediator = mediator;
        _personValidator = personValidator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPeopleAsync()
    {
        var people = await _mediator.Send(new GetPeopleQuery());
        return people.Data != null
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
        var person = await _mediator.Send(new AddPersonCommand(newPerson));
        return person.Data != null
            ? Ok(person)
            : BadRequest(person.Data);
    }
}