using System.Data.SqlTypes;

namespace ApiMediaRDemo.DTOs;

public record PersonInput(string FullName, byte Age);