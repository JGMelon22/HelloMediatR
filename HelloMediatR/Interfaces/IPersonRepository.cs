namespace ApiMediaRDemo.Interfaces;

public interface IPersonRepository
{
    Task<ServiceResponse<PersonResult>> AddNewPersonAsync(PersonRequest newPerson);
    Task<ServiceResponse<List<PersonResult>>> GetAllPeopleAsync();
    Task<ServiceResponse<PersonResult>> GetPersonByIdAsync(Guid id);
    Task<ServiceResponse<PersonResult>> UpdatePersonAsync(Guid id, PersonRequest updatedPerson);
    Task<ServiceResponse<bool>> RemovePersonAsync(Guid id);
}
