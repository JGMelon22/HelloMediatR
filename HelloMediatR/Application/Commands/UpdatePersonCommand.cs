using MediatR;

namespace HelloMediatR.Application.Commands;

public record UpdatePersonCommand(Guid Id, PersonRequest UpdatedPerson) : IRequest<ServiceResponse<PersonResult>>;
