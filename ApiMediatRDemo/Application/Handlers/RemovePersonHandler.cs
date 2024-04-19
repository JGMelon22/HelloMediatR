using ApiMediaRDemo.Interfaces;
using ApiMediatRDemo.Application.Commands;
using MediatR;

namespace ApiMediatRDemo.Application.Handlers;

public class RemovePersonHandler : IRequestHandler<RemovePersonCommand, ServiceResponse<bool>>
{
    private readonly IPersonRepository _personRepository;   
    public RemovePersonHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<bool>> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.RemovePersonAsync(request.id);
    }
}