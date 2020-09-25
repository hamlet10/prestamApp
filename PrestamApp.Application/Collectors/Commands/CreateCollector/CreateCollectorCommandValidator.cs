using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Collectors.Commands
{
    public class CreateCollectorCommandValidator : AbstractValidator<CreateCollectorCommand>
    {
        public CreateCollectorCommandValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.Name).MaximumLength(50);
            RuleFor(c => c.Address).MaximumLength(70).NotEmpty();
            RuleFor(c => c.PhoneNumberOne).MaximumLength(13).NotEmpty();
            RuleFor(c => c.PhoneNumberTwo).MaximumLength(13);
            RuleFor(c => c.Email).MaximumLength(50).EmailAddress().NotEmpty();
        }

    }
}
