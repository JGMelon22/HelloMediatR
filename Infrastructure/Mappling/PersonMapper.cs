using ApiMediaRDemo.DTOs;
using ApiMediaRDemo.Models;
using Riok.Mapperly.Abstractions;

namespace ApiMediaRDemo.Infrastructure.Mappling;

[Mapper]
public static partial class PersonMapper
{
    public static partial PersonResult PersonToPersonResult(Person person);
    public static partial Person PersonToPersonInput(PersonInput person);
    public static partial void ApplyUpdate(PersonInput updatedPerson, Person person);
}