using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Contacts.Commands.DeleteContact
{
    public class DeleteContactCommandValidator : AbstractValidator<DeleteContactCommand>
    {
        public DeleteContactCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
