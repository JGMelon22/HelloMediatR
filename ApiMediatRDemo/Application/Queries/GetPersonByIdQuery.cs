using MediatR;

namespace ApiMediaRDemo.Application.Queries;

public record GetPersonByIdQuery(Guid id) : IRequest<ServiceResponse<PersonResult>>;