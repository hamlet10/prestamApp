using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Commands.CreateLoan
{
    public class CreateLoanCommand : IRequest
    {
        public int ContactId { get; set; }
        public string UrlFile { get; set; }
        public int TimeFrameId { get; set; }
        public decimal LoanAmount { get; set; }
        public bool SimpleInterest { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Interest { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDue { get; set; }
        public decimal TotalBalance { get; set; } //Capita e Interes menos pagos realizados
        public bool IsActive { get; set; }
        public bool UpToDate { get; set; }
        //public string Code { get; set; }
        public decimal TotalCapitalAmount { get; set; }
    }
}
