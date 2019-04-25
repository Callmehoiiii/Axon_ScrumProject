using System;
using System.Collections.Generic;

namespace ScrumProject.Models
{
    public partial class Account
    {
        public Account()
        {
            House = new HashSet<House>();
        }

        public int IdAcc { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User User { get; set; }
        public ICollection<House> House { get; set; }
    }
}
