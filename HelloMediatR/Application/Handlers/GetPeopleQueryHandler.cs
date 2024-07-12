using ApiMediaRDemo.Application.Queries;

using ApiMediaRDemo.Interfaces;
using MediatR;

namespace ApiMediaRDemo.Application.Handlers;

public class GetPeopleQueryHandler : IRequestHandler<GetPeopleQuery, ServiceResponse<List<PersonResult>>>
{
    private readonly IPersonRepository _personRepository;

    public GetPeopleQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<List<PersonResult>>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
    {
        return await _personRepository.GetAllPeopleAsync();
    }
}