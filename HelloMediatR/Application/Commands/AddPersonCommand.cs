using MediatR;

namespace HelloMediatR.Application.Commands;

public record AddPersonCommand(PersonRequest NewPerson) : IRequest<ServiceResponse<PersonResult>>;
