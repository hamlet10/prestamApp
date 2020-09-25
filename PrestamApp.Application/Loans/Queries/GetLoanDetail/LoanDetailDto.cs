using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Loans.Queries.GetLoanDetail
{
    public class LoanDetailDto : IHaveCustomMapping
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        //public int statusid { get; set; }
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
        public string Code { get; set; }
        public int? NumberOfDuesPaid { get; set; }
        public decimal TotalCapitalAmount { get; set; } //Capital que ha pagado
        public string ContactName { get; set; }
        public string TimeFrameDescription { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Loan, LoanDetailDto>()
                .ForMember(dto => dto.ContactName, opts => opts.MapFrom(c => c.Contact.Name))
                .ForMember(dto => dto.TimeFrameDescription, opts => opts.MapFrom(t => t.TimeFrame.Description));
        }
    }
}
