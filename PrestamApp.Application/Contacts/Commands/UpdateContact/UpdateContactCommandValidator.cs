using FluentValidation;

namespace PrestamApp.Application.Contacts.Commands.UpdateContact
{
    public class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
    {
        public UpdateContactCommandValidator()
        {
            RuleFor(c => c.IdentificationNumber).MaximumLength(13).NotEmpty();
            RuleFor(c => c.UrlFile).MaximumLength(50);
            RuleFor(c => c.Name).MaximumLength(50).NotEmpty();
            RuleFor(c => c.LastName).MaximumLength(50).NotEmpty();
            RuleFor(c => c.Email).MaximumLength(50).EmailAddress();
            RuleFor(c => c.Gender).NotEmpty();
            RuleFor(c => c.Address).MaximumLength(70).NotEmpty();
            RuleFor(c => c.PhoneNumberOne).MaximumLength(20).NotEmpty();
            RuleFor(c => c.PhoneNumberTwo).MaximumLength(20);
            RuleFor(c => c.ZoneId).NotEmpty();
            RuleFor(c => c.AddressTypeId).NotEmpty();
            RuleFor(c => c.AddressDataId).NotEmpty();
            RuleFor(c => c.AddressReference).MaximumLength(30);
        }
    }
}