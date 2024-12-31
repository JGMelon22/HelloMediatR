using Riok.Mapperly.Abstractions;

namespace ApiMediaRDemo.Infrastructure.Mappling;

[Mapper]
public static partial class PersonMapper
{
    public static partial PersonResult PersonToPersonResult(Person person);
    public static partial Person PersonRequestToPerson(PersonRequest person);
    public static partial void ApplyUpdate(PersonRequest updatedPerson, Person person);
}
