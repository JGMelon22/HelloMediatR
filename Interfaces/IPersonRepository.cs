namespace ApiMediaRDemo.Interfaces;

public interface IPersonRepository
{
    Task<ServiceResponse<PersonResult>> AddNewPersonAsync(PersonInput newPerson);
    Task<ServiceResponse<List<PersonResult>>> GetAllPeopleAsync();
    Task<ServiceResponse<PersonResult>> GetPersonByIdAsync(Guid id);
    Task<ServiceResponse<PersonResult>> UpdatePersonAsync(Guid id, PersonInput updatedPerson);
    Task<ServiceResponse<bool>> RemovePersonAsync(Guid id);
}