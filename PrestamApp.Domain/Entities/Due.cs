using System;
using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class Due : IAuditable
    {
        public int DueID { get; set; }
        public int LoanID { get; set; }
        public DateTime Date { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal LateFee { get; set; }
        public decimal PendingBalance { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal? AdvancePayment { get; set; }
       
        public int DueNumber { get; set; }
        public bool DueIsPaidOff { get; set; }

        public  Loan Loans { get; set; }
        public  ICollection<DuePayment> DuesPayments { get; set; }

    }
}