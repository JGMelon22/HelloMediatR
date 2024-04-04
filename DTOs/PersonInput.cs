using System.Data.SqlTypes;

namespace ApiMediatRDemo.DTOs;

public record PersonInput(string FullName, byte Age);