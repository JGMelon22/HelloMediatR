using System.Data.SqlTypes;

namespace ApiMediaRDemo.Models;

public class Person
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty!;
    public byte Age { get; set; }
}