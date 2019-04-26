using ScrumProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumProject.BAL
{
    public class UserBAL
    {
        private Scrum_StudentAccomodationContext context;

        public UserBAL(Scrum_StudentAccomodationContext context)
        {
            this.context = context;
        }

        public User GetUser(int idUser)
        {
            var user = context.User.First(a => a.IdAcc == idUser);
            return user;
        }

        public Task<int> InsertUser(User user)
        {
            context.User.Add(user);
            return context.SaveChangesAsync();
        }
    }
}
