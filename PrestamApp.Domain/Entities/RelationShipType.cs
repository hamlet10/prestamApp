using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Domain.Entities
{
    public class RelationShipType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<PersonalRefference> personalRefferences { get; set; }
    }
}
