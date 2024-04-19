using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record AddPersonCommand(PersonInput newPerson) : IRequest<ServiceResponse<PersonResult>>;