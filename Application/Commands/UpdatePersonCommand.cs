using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using MediatR;

namespace ApiMediatRDemo.Application.Commands;

public record UpdatePersonCommand(Guid id, PersonInput updatedPerson) : IRequest<ServiceResponse<PersonResult>>;