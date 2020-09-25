using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
    public class AddressType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public  ICollection<Address> Addresses { get; set; }

    }
}