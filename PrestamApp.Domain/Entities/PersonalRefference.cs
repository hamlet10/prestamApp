using NetTopologySuite.Geometries;

namespace PrestamApp.Domain.Entities
{
  public class PersonalRefference : IAuditable
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ContactId { get; set; }
    public int RelationShipTypeId { get; set; }
    public string Address { get; set; }
    public Geometry Location { get; set; }
    public string PhoneNumberOne { get; set; }
    public string PhoneNumberTwo { get; set; }
    public RelationShipType RelationShipType { get; set; }
    public Contact Contact { get; set; }
  }
}