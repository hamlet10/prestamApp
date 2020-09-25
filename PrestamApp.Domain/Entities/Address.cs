using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace PrestamApp.Domain.Entities
{
  public class Address : IAuditable
  {
    public int Id { get; set; }
    public string Refference { get; set; }
    public string Street { get; set; }
    public Geometry Location { get; set; }
    public int AddressTypeId { get; set; }
    public int? AddressDataId { get; set; }
    public AddressType AddressType { get; set; }
    public ICollection<Contact> Contacts { get; set; }
    public AddressData AddressData { get; set; }
  }
}
