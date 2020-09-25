using System;
using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class Loan : IAuditable
    {
        public Loan()
        {
            Dues = new HashSet<Due>();
        }
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
        public Contact Contact { get; set; }
        public TimeFrame TimeFrame { get; set; }

        public ICollection<Due> Dues { get; set; }
    }
}