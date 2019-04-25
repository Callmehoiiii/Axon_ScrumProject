using System;
using System.Collections.Generic;

namespace ScrumProject.Models
{
    public partial class HouseType
    {
        public HouseType()
        {
            House = new HashSet<House>();
        }

        public int IdType { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public ICollection<House> House { get; set; }
    }
}
