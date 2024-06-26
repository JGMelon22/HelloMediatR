namespace ApiMediaRDemo.DTOs;

public record PersonResult
{
    public Guid Id { get; init; }
    public string FullName { get; init; } = string.Empty!;
    public byte Age { get; init; }
}
