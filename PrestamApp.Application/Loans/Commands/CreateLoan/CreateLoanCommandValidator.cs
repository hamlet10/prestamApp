using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Commands.CreateLoan
{
    class CreateLoanCommandValidator : AbstractValidator<CreateLoanCommand>
    {
        public CreateLoanCommandValidator()
        {
            RuleFor(l => l.ContactId).NotNull();
            RuleFor(l => l.UrlFile).MaximumLength(50);
            RuleFor(l => l.TimeFrameId).NotNull();
            RuleFor(l => l.LoanAmount).NotNull();
            RuleFor(l => l.SimpleInterest).NotNull();
            RuleFor(l => l.InterestRate).NotNull();
            RuleFor(l => l.Interest).NotNull();
            RuleFor(l => l.LoanDate).NotNull();
            RuleFor(l => l.EndDate).NotNull();
            RuleFor(l => l.NumberOfDue).NotNull();
            RuleFor(l => l.TotalBalance).NotNull();
            RuleFor(l => l.IsActive).NotNull();
            RuleFor(l => l.UpToDate).NotNull();
            //RuleFor(l => l.Code).NotNull();
            RuleFor(l => l.TotalCapitalAmount).NotNull();

        }
    }
}
