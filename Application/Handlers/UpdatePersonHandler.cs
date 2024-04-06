using ApiMediaRDemo.Interfaces;
using ApiMediatRDemo.Application.Commands;
using MediatR;

namespace ApiMediatRDemo.Application.Handlers;

public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;
    public UpdatePersonHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.UpdatePersonAsync(request.id, request.updatedPerson);
    }
}