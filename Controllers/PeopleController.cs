using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
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
}