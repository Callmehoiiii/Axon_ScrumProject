using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumProject.BAL;
using ScrumProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScrumProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        private Scrum_StudentAccomodationContext context;
        private LoginBAL loginBal;

        public LoginController(Scrum_StudentAccomodationContext context)
        {
            this.context = context;
            loginBal = new LoginBAL(context);
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            User user = loginBal.Login(username, password);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Post", user);
        }
    }
}
