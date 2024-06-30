using MediatR;

namespace HelloMediatR.Application.Commands;

public record UpdatePersonCommand(Guid Id, PersonInput UpdatedPerson) : IRequest<ServiceResponse<PersonResult>>;