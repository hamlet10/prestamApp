using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class Zone : IAuditable
    {
        public Zone()
        {
            Contacts = new HashSet<Contact>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Contact> Contacts { get; private set; }
        public ICollection<ZoneCollector> ZoneCollectors { get; set; }
    }
}
