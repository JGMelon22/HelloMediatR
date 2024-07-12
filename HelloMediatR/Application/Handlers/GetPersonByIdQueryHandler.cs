using ApiMediaRDemo.Application.Queries;

using ApiMediaRDemo.Interfaces;
using MediatR;

namespace HelloMediatR.Application.Handlers;

public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;
    public GetPersonByIdQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return await _personRepository.GetPersonByIdAsync(request.Id);
    }
}