using System;
using System.Collections.Generic;

namespace ScrumProject.Models
{
    public partial class House
    {
        public int IdHouse { get; set; }
        public int IdAcc { get; set; }
        public int IdType { get; set; }
        public string Adress { get; set; }
        public string Area { get; set; }
        public string Price { get; set; }
        public string Contact { get; set; }
        public string Image { get; set; }

        public Account IdAccNavigation { get; set; }
        public HouseType IdTypeNavigation { get; set; }
    }
}
