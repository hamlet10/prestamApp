using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace PrestamApp.Domain.Entities
{
  public class AddressData
    {
        
        public int Id { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int LevelId { get; set; }
        public Geometry Coordinate { get; set; }

        public  AddressData Parent { get; set; }

        public ICollection<Address> Address { get; set; }

        public ICollection<AddressData> Childs { get; set; }

    }
}
