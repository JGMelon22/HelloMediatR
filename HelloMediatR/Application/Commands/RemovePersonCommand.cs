using MediatR;

namespace HelloMediatR.Application.Commands;

public record RemovePersonCommand(Guid Id) : IRequest<ServiceResponse<bool>>;