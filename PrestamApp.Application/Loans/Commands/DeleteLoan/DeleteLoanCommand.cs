using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Commands.DeleteLoan
{
    public class DeleteLoanCommand : IRequest
    {
        public int Id { get; set; }

    }
}
