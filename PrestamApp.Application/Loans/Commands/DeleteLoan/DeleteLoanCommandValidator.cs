using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Commands.DeleteLoan
{
    public class DeleteLoanCommandValidator : AbstractValidator<DeleteLoanCommand>
    {
        public DeleteLoanCommandValidator()
        {
            RuleFor(l => l.Id).NotEmpty();
        }
    }
}
