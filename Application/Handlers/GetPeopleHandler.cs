using ApiMediaRDemo.Application.Queries;
using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Interfaces;
using ApiMediaRDemo.Models;
using MediatR;

namespace ApiMediaRDemo.Application.Handlers;

public class GetPeopleHandler : IRequestHandler<GetPeopleQuery, ServiceResponse<List<PersonResult>>>
{
    private readonly IPersonRepository _personRepository;

    public GetPeopleHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<List<PersonResult>>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
    {
        return await _personRepository.GetAllPeopleAsync();
    }
}