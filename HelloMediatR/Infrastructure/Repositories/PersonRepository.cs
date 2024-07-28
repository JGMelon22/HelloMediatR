using ApiMediaRDemo.Infrastructure.Data;
using ApiMediaRDemo.Infrastructure.Mappling;
using ApiMediaRDemo.Interfaces;
using System.Reflection;

using Microsoft.EntityFrameworkCore;

namespace ApiMediaRDemo.Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<PersonRepository> _logger;

    public PersonRepository(AppDbContext dbContext, ILogger<PersonRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<ServiceResponse<PersonResult>> AddNewPersonAsync(PersonInput newPerson)
    {
        var serviceResponse = new ServiceResponse<PersonResult>();

        try
        {
            var person = PersonMapper.PersonToPersonInput(newPerson);
            var methodNameLog = $"[{GetType().Name} -> {MethodBase.GetCurrentMethod()!.ReflectedType!.Name}]";

            _logger.LogInformation("{methodName} {objectName}: {@newPerson}", methodNameLog, nameof(newPerson), newPerson);

            await _dbContext.People.AddAsync(person);
            await _dbContext.SaveChangesAsync();

            var personResult = PersonMapper.PersonToPersonResult(person);

            serviceResponse.Data = personResult;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, GetType().Name);

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
            var methodNameLog = $"[{GetType().Name} -> {MethodBase.GetCurrentMethod()!.ReflectedType!.Name}]";

            var people = await _dbContext.People
                .AsNoTracking()
                .ToListAsync();

            _logger.LogInformation("{methodName} {objectName}: {@people}", methodNameLog, nameof(people), people);

            var peopleResult = people.Select(PersonMapper.PersonToPersonResult).ToList();

            serviceResponse.Data = peopleResult;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, GetType().Name);

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
            var methodNameLog = $"[{GetType().Name} -> {MethodBase.GetCurrentMethod()!.ReflectedType!.Name}]";

            var person = await _dbContext.People
                .FindAsync(id)
                ?? throw new Exception($"Person with id {id} not found!");

            _logger.LogInformation("{methodName} {objectName}: {@person}", methodNameLog, nameof(person), person);

            serviceResponse.Data = PersonMapper.PersonToPersonResult(person);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, GetType().Name);

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
            var methodNameLog = $"[{GetType().Name} -> {MethodBase.GetCurrentMethod()!.ReflectedType!.Name}]";

            var person = await _dbContext.People
                .FindAsync(id)
                ?? throw new Exception($"Person with id {id} not found!");

            _logger.LogInformation("{methodName} {objectName}: {@person}", methodNameLog, nameof(person), person);

            _dbContext.People.Remove(person);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message, GetType().Name);

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
            var methodNameLog = $"[{GetType().Name} -> {MethodBase.GetCurrentMethod()!.ReflectedType!.Name}]";

            _logger.LogInformation("{methodName} {objectName}: {@updatedPerson}", methodNameLog, nameof(updatedPerson), updatedPerson);

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
            _logger.LogError(ex, ex.Message, GetType().Name);

            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }
}
