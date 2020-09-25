using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class Collector : IAuditable
    {
        public Collector()
        {
            ZoneCollectors = new HashSet<ZoneCollector>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string Email { get; set; }

        public ICollection<ZoneCollector> ZoneCollectors { get; set; }

    }
}