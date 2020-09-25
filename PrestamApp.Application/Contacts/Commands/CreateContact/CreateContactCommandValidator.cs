using FluentValidation;

namespace PrestamApp.Application.Contacts.Commands.CreateContact
{
    public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactCommandValidator()
        {
            //RuleFor(c => c.ContactNumber).MaximumLength(10);
            RuleFor(c => c.IdentificationNumber).MaximumLength(13).NotEmpty();
            RuleFor(c => c.UrlFile).MaximumLength(50);
            RuleFor(c => c.Name).MaximumLength(50).NotEmpty();
            RuleFor(c => c.LastName).MaximumLength(50).NotEmpty();
            RuleFor(c => c.Email).MaximumLength(50).EmailAddress();
            RuleFor(c => c.Gender).NotEmpty();
            RuleFor(c => c.PhoneNumberOne).MaximumLength(20).NotEmpty();
            RuleFor(c => c.PhoneNumberTwo).MaximumLength(20);
            RuleFor(c => c.ZoneId).NotEmpty();
            RuleFor(c => c.AddressTypeId).NotEmpty();
            
        }
    }
}