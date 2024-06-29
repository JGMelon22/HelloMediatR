using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record AddPersonCommand(PersonInput NewPerson) : IRequest<ServiceResponse<PersonResult>>;