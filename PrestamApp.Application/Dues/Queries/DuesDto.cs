using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Dues
{
    public class DuesDto : IHaveCustomMapping
    {
        public int DueID { get; set; }
        public int LoanId { get; set; }
        public int DueNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal LateFee { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal? AdvancePayment { get; set; }
        public bool DueIsPaidOff { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Due, DuesDto>();
        }
    }
}
