using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using MediatR;

namespace ApiMediaRDemo.Application.Queries;

public record GetPeopleQuery() : IRequest<ServiceResponse<List<PersonResult>>>;