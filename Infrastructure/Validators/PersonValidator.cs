using ApiMediaRDemo.DTOs;
using FluentValidation;

namespace ApiMediaRDemo.Infrastructure.Validators;

public class PersonValidator : AbstractValidator<PersonInput>
{
    public PersonValidator()
    {
        RuleFor(p => p.FullName)
            .NotEmpty()
            .WithMessage("Full Name is a required field!")
            .NotNull()
            .WithMessage("Full Name is a required field!")
            .MinimumLength(2)
            .WithMessage("Full Name must contain at least 2 characters!")
            .MaximumLength(100)
            .WithMessage("Full Name can not exceed 100 characters!");

        RuleFor(p => p.Age)
            .NotEmpty()
            .WithMessage("Age is a required field!")
            .NotNull()
            .WithMessage("Age Name is a required field!")
            .Must(age => age > 18)
            .WithMessage("Age must be greater than 18 years old!");
    }
}