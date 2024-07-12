using ApiMediaRDemo.Interfaces;
using HelloMediatR.Application.Commands;
using MediatR;

namespace HelloMediatR.Application.Handlers;

public class RemovePersonCommandHandler : IRequestHandler<RemovePersonCommand, ServiceResponse<bool>>
{
    private readonly IPersonRepository _personRepository;   
    public RemovePersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<bool>> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.RemovePersonAsync(request.Id);
    }
}