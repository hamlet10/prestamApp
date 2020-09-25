using System;
using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class Payment : IAuditable
    {
        public int PaymentID { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public decimal CapitalAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal LateFee { get; set; }
        public decimal PendigBalance { get; set; }
        public decimal TotalBalance { get; set; }

        public ICollection<DuePayment> DuesPayments { get; set; }

    }
}