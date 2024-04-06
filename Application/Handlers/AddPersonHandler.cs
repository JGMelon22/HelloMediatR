using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using ApiMediatRDemo.Application.Commands;
using MediatR;

namespace ApiMediatRDemo.Application.Handlers;

public class AddPersonHandler : IRequestHandler<AddPersonCommand, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;

    public AddPersonHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.AddNewPersonAsync(request.newPerson);
    }
}