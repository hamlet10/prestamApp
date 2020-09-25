using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class TimeFrame 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CountDay { get; set; }
        public ICollection<Loan> Loan { get; set; }
    }
}