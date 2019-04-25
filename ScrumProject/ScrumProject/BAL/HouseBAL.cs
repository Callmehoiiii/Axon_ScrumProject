using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScrumProject.Models;

namespace ScrumProject.BAL
{
    public class HouseBAL
    {
        private Scrum_StudentAccomodationContext context;

        public HouseBAL(Scrum_StudentAccomodationContext context)
        {
            this.context = context;
        }

        public List<House> getAllHouse()
        {

            return context.House.Include(x => x.IdAccNavigation).Include(x => x.IdAccNavigation.User).ToList();

        }

        public int NextIDHouse()
        {
            return context.House.Count();
        }

        public Task<int> InsertHouse(House house)
        {
            context.House.Add(house);
            return context.SaveChangesAsync();
        }
    }
}
