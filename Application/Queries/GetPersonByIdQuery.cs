using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using MediatR;

namespace ApiMediaRDemo.Application.Queries;

public record GetPersonByIdQuery() : IRequest<ServiceResponse<PersonResult>>;