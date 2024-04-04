using ApiMediatRDemo.DTOs;
using ApiMediatRDemo.Infrastructure.Data;
using ApiMediatRDemo.Infrastructure.Mappling;
using ApiMediatRDemo.Interfaces;
using ApiMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMediatRDemo.Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly AppDbContext _dbContext;

    public PersonRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ServiceResponse<PersonResult>> AddNewPersonAsync(PersonInput newPerson)
    {
        var serviceResponse = new ServiceResponse<PersonResult>();

        try
        {
            var person = PersonMapper.PersonToPersonInput(newPerson);

            await _dbContext.People.AddAsync(person);
            await _dbContext.SaveChangesAsync();

            var personResult = PersonMapper.PersonToPersonResult(person);

            serviceResponse.Data = personResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<PersonResult>>> GetAllPeopleAsync()
    {
        var serviceResponse = new ServiceResponse<List<PersonResult>>();

        try
        {
            var people = await _dbContext.People
                .AsNoTracking()
                .ToListAsync()
                ?? throw new Exception("People list is empty!");

            var peopleResult = people.Select(PersonMapper.PersonToPersonResult).ToList();

            serviceResponse.Data = peopleResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<PersonResult>> GetPersonByIdAsync(Guid id)
    {
        var serviceResponse = new ServiceResponse<PersonResult>();

        try
        {
            var person = await _dbContext.People
                .FindAsync(id)
                ?? throw new Exception($"Person with id {id} not found!");

            serviceResponse.Data = PersonMapper.PersonToPersonResult(person);
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<bool>> RemovePersonAsync(Guid id)
    {
        var serviceResponse = new ServiceResponse<bool>();

        try
        {
            var person = await _dbContext.People
                .FindAsync(id)
                ?? throw new Exception($"Person with id {id} not found!");
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<PersonResult>> UpdatePersonAsync(Guid id, PersonInput updatedPerson)
    {
        var serviceResponse = new ServiceResponse<PersonResult>();

        try
        {
            var person = await _dbContext.People
                .FindAsync(id)
                ?? throw new Exception($"Person with id {id} not found!");

            PersonMapper.ApplyUpdate(updatedPerson, person);

            await _dbContext.SaveChangesAsync();

            var personResult = PersonMapper.PersonToPersonResult(person);

            serviceResponse.Data = personResult;
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }
}