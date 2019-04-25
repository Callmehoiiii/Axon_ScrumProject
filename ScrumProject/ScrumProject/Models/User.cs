using System;
using System.Collections.Generic;

namespace ScrumProject.Models
{
    public partial class User
    {
        public int IdAcc { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Account IdAccNavigation { get; set; }
    }
}
