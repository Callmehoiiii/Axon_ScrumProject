﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumProject.Models;

namespace ScrumProject.BAL
{
    public class LoginBAL
    {
        private Scrum_StudentAccomodationContext context;

        public LoginBAL(Scrum_StudentAccomodationContext context)
        {
            this.context = context;
        }

        public User Login(string username, string password)
        {
            return context.User.Include(user => user.IdAccNavigation)
                .FirstOrDefault(user =>
                    user.IdAccNavigation.UserName == username && user.IdAccNavigation.Password == password);
        }
    }
}
