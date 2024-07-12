using ApiMediaRDemo.Interfaces;
using HelloMediatR.Application.Commands;
using MediatR;

namespace HelloMediatR.Application.Handlers;

public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, ServiceResponse<PersonResult>>
{
    private readonly IPersonRepository _personRepository;

    public AddPersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ServiceResponse<PersonResult>> Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        return await _personRepository.AddNewPersonAsync(request.NewPerson);
    }
}