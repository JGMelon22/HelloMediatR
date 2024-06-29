using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record UpdatePersonCommand(Guid Id, PersonInput UpdatedPerson) : IRequest<ServiceResponse<PersonResult>>;