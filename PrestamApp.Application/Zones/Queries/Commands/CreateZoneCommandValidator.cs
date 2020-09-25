using FluentValidation;
using PrestamApp.Application.Zones.Queries.Commands;

namespace PrestamApp.Application.Contacts.Commands.CreateContact
{
    public class CreateZoneCommandValidator : AbstractValidator<CreateZoneCommand>

    {
        public CreateZoneCommandValidator()

        {
            RuleFor(c => c.Description).MaximumLength(50).NotEmpty();

        }
    }
}