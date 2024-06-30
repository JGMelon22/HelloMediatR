using ApiMediaRDemo.Interfaces;
using HelloMediatR.Application.Commands;
using MediatR;

namespace HelloMediatR.Application.Handlers;

public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;
    public UpdatePersonHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.UpdatePersonAsync(request.Id, request.UpdatedPerson);
    }
}