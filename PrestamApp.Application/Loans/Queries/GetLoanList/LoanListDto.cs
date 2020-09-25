using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Application.Loans.Queries.GetLoanList
{
    public class LoanListDto : IHaveCustomMapping


    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhoneNumberOne { get; set; }
        public string ZoneName { get; set; }
        public int NumberOfDue { get; set; }
        public decimal dueAmount { get; set; }
        public int? NumberOfDuesPaid { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal TotalCapitalAmount { get; set; }
        
        

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Loan, LoanListDto>()
                .ForMember(dto => dto.ContactId, opt => opt.MapFrom(l => l.ContactId)).
                 ForMember(dto => dto.ContactName, opt => opt.MapFrom(l => l.Contact.Name));

            configuration.CreateMap<Loan, LoanListDto>()
                .ForMember(dto => dto.ContactId, opt => opt.MapFrom(l => l.ContactId)).
                 ForMember(dto => dto.ContactLastName, opt => opt.MapFrom(l => l.Contact.LastName));

            configuration.CreateMap<Loan, LoanListDto>()
                .ForMember(dto => dto.ContactId, opt => opt.MapFrom(l => l.ContactId)).
                 ForMember(dto => dto.ZoneName, opt => opt.MapFrom(l => l.Contact.Zone.Description));

            configuration.CreateMap<Loan, LoanListDto>()
                .ForMember(dto => dto.dueAmount, opt => opt.MapFrom(l =>
                 (l.LoanAmount + l.Interest) / l.NumberOfDue 
                )) ;
        }
    }
}
