using ApiMediaRDemo.Application.Queries;

using ApiMediaRDemo.Interfaces;
using MediatR;

namespace ApiMediatRDemo.Application.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;
    public GetPersonByIdHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return await _personRepository.GetPersonByIdAsync(request.Id);
    }
}