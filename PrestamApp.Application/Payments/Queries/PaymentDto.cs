using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;

namespace PrestamApp.Application.Payments
{
    public class PaymentDto : IHaveCustomMapping
    {
        public int LoanID { get; set; }
        public int DueID { get; set; }
        public int PaymentID { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal LateFee { get; set; }
        public decimal PendigBalance { get; set; }
        public decimal TotalBalance { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Payment, PaymentDto>();
        }
    }
}
