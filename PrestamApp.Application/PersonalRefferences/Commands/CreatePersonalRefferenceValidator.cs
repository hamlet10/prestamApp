using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.PersonalRefferences.Commands
{
    class CreatePersonalRefferenceValidator : AbstractValidator<CreatePersonalRefferenceCommand>
    {
        public CreatePersonalRefferenceValidator()
        {
            RuleFor(r => r.Name).MaximumLength(150).NotEmpty();
            RuleFor(r => r.ContactId).NotEmpty();
            RuleFor(r => r.RelationShipTypeId).NotEmpty();
            RuleFor(r => r.Address).NotEmpty();
            RuleFor(r => r.PhoneNumberOne).MaximumLength(13).NotEmpty();

        }
    }
}
