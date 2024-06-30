using MediatR;

namespace HelloMediatR.Application.Commands;

public record AddPersonCommand(PersonInput NewPerson) : IRequest<ServiceResponse<PersonResult>>;