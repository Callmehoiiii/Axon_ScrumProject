using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScrumProject.Models;

namespace ScrumProject.BAL
{
    public class HouseTypeBAL
    {
        private Scrum_StudentAccomodationContext context;

        public HouseTypeBAL(Scrum_StudentAccomodationContext context)
        {
            this.context = context;
        }

        public List<HouseType> GetListHouseTypes()
        {
            return context.HouseType.ToList();
        }
    }
}
