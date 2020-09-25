using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Collectors.Commands.DeleteCollector
{
    public class DeleteCollectorCommandValidator : AbstractValidator<DeleteCollectorCommand>
    {
        public DeleteCollectorCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
