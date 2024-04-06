using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record RemovePersonCommand(Guid id) : IRequest<ServiceResponse<bool>>;