using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record RemovePersonCommand(Guid Id) : IRequest<ServiceResponse<bool>>;