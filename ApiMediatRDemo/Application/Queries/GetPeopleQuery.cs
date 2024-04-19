using MediatR;

namespace ApiMediaRDemo.Application.Queries;

public record GetPeopleQuery() : IRequest<ServiceResponse<List<PersonResult>>>;