using MediatR;

namespace ApiMediaRDemo.Application.Queries;

public record GetPersonByIdQuery(Guid Id) : IRequest<ServiceResponse<PersonResult>>;