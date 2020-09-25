using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Zones.Queries.Commands.DeleteZone
{
    class DeleteZoneCommandValidator : AbstractValidator<DeleteZoneCommand>
    {
        public DeleteZoneCommandValidator()
        {
            RuleFor(z => z.Id).NotEmpty();
        }
    }
}
